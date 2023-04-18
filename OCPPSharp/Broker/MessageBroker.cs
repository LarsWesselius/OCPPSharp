using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OCPPSharp.Messages;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace OCPPSharp.Broker;

public class MessageBroker
{
    private readonly ILogger<MessageBroker> _logger;
    private readonly IServiceProvider _serviceProvider;
    private Dictionary<string, Type> _messagesTypes = new Dictionary<string, Type>();
    private Dictionary<string, Type> _inheritanceTypeCache = new Dictionary<string, Type>();

    private ConcurrentDictionary<string, string> _expectingMessageResults = new ConcurrentDictionary<string, string>();

    public MessageBroker(ILogger<MessageBroker> logger, IServiceProvider serviceProvider)
    {
        var allTypes = typeof(MessageBroker).Assembly.GetTypes().Where(z => z.Namespace == "OCPPSharp.Messages" && (z.Name.EndsWith("Request") || z.Name.EndsWith("Response")));
        foreach (var type in allTypes)
        {
            _messagesTypes[type.Name] = type;
            var interfaceType = typeof(MessageHandler<>).MakeGenericType(type);
            _inheritanceTypeCache[type.Name] = interfaceType;
        }

        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    internal async Task HandleMessageAsync(string rawMessage, ClientContext clientContext, CancellationToken cancellationToken)
    {
        var messageArray = JsonArray.Parse(rawMessage);

        var messageTypeId = (MessageType)messageArray[0].GetValue<int>();
        string messageId = messageArray[1].GetValue<string>();

        switch (messageTypeId)
        {
            case MessageType.Call:
                await HandleCall(messageArray, clientContext, messageId, cancellationToken);
                break;
            case MessageType.CallResult:
                await HandleCallResult(messageArray, clientContext, messageId, cancellationToken);
                break;
            case MessageType.CallError:
                _logger.LogError($"Call error received {messageArray[2].GetValue<string>()}");
                break;
        }
    }

    private async Task HandleCall(JsonNode messageArray, ClientContext clientContext, string messageId, CancellationToken cancellationToken)
    {
        string action = messageArray[2].GetValue<string>();
        JsonObject jsonObject = (JsonObject)messageArray[3];

        _logger.LogDebug($"<-- Message received of type call. Action: {action} Id: {messageId}");

        await HandleMessageAsync(new MessageContext()
        {
            WebSocket = clientContext.WebSocket,
            ClientId = clientContext.Id,
            RawMessage = new Message()
            {
                Action = action,
                MessageId = messageId,
                JsonObject = jsonObject,
                MessageType = MessageType.Call
            }
        }, cancellationToken);
    }

    private async Task HandleCallResult(JsonNode messageArray, ClientContext clientContext, string messageId, CancellationToken cancellationToken)
    {
        JsonObject jsonObject = (JsonObject)messageArray[2];
        _logger.LogDebug($"<-- Message received of type call result. Id: {messageId}");

        await HandleResponseAsync(new MessageContext()
        {
            WebSocket = clientContext.WebSocket,
            ClientId = clientContext.Id,
            RawMessage = new Message()
            {
                MessageId = messageId,
                JsonObject = jsonObject,
                MessageType = MessageType.CallResult
            }
        }, cancellationToken);
    }

    internal async Task HandleMessageAsync(MessageContext messageContext, CancellationToken cancellationToken)
    {
        // Identify action
        var correspondingType = _messagesTypes.FirstOrDefault(z => z.Key.StartsWith(messageContext.RawMessage.Action));
        var interfaceType = _inheritanceTypeCache[correspondingType.Key];

        using var scope = _serviceProvider.CreateScope();

        var handler = (IMessageHandler?)scope.ServiceProvider.GetService(interfaceType);
        if (handler == null)
        {
            _logger.LogWarning($"No handler for {messageContext.RawMessage.Action}");
            await SendResponseAsync(messageContext, new ErrorMessage()
            {
                ErrorCode = "NoHandlerForAction",
                ErrorDescription = $"No handler available for request type {messageContext.RawMessage.Action}"
            }, cancellationToken);
            return;
        }
        _logger.LogTrace($"Handler found for action {messageContext.RawMessage.Action}: {handler.GetType().Name}");
        var response = await handler.HandleMessageAsync(messageContext, cancellationToken);
        if (response == null)
        {
            _logger.LogTrace($"Handler did not return a response");
            return;
        }

        _logger.LogTrace($"Handler returned a response of type {response.GetType().Name}");
        await SendResponseAsync(messageContext, response, cancellationToken);
    }

    internal async Task HandleResponseAsync(MessageContext messageContext, CancellationToken cancellationToken)
    {
        if (!_expectingMessageResults.Remove(messageContext.RawMessage.MessageId, out var expectingResponseType))
            return;

        var correspondingType = _messagesTypes.FirstOrDefault(z => z.Key.StartsWith(expectingResponseType));
        var interfaceType = _inheritanceTypeCache[correspondingType.Key];

        using var scope = _serviceProvider.CreateScope();

        var handler = (IMessageHandler)scope.ServiceProvider.GetService(interfaceType);
        if (handler == null)
        {
            _logger.LogWarning($"No handler for {expectingResponseType}");
            return;
        }
        _logger.LogTrace($"Handler found for action {expectingResponseType}: {handler.GetType().Name}");

        await handler.HandleMessageAsync(messageContext, cancellationToken);
    }

    private async Task SendResponseAsync(MessageContext messageContext, object response, CancellationToken cancellationToken)
    {
        object[] responseArray;
        if (response is ErrorMessage errorMessage)
        {
            responseArray = new object[]
            {
                (int)MessageType.CallError,
                messageContext.RawMessage.MessageId,
                errorMessage.ErrorCode,
                errorMessage.ErrorDescription,
                errorMessage.ErrorDetails != null ? JsonObject.Parse(JsonSerializer.Serialize(errorMessage.ErrorDetails)) : new { }
            };
        }
        else
        {
            responseArray = new object[]
            {
                (int)MessageType.CallResult,
                messageContext.RawMessage.MessageId,
                JsonNode.Parse(JsonSerializer.Serialize(response))
            };
        }

        var finalMessage = JsonSerializer.Serialize(responseArray);

        var bytes = Encoding.UTF8.GetBytes(finalMessage);
        await messageContext.WebSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, cancellationToken);
    }

    public async Task SendRequestAsync<T>(WebSocket socket, object request)
    {
        var typeName = request.GetType().Name;
        var id = Guid.NewGuid().ToString();
        var requestArray = new object[]
        {
            (int)MessageType.Call,
            id,
            typeName.Replace("Response", "").Replace("Request", ""),
            JsonObject.Parse(JsonSerializer.Serialize(request))
        };

        _expectingMessageResults[id] = typeof(T).Name;

        var finalMessage = JsonSerializer.Serialize(requestArray);
        var bytes = Encoding.UTF8.GetBytes(finalMessage);

        _logger.LogTrace($"--> Sending request of type {request.GetType().Name} with message Id {requestArray[1]}");
        await socket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
    }
}
