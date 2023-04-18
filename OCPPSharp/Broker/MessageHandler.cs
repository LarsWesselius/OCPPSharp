using OCPPSharp.Messages;
using System.Text.Json;

namespace OCPPSharp.Broker;

public abstract class MessageHandler<T> : IMessageHandler where T : class
{
    protected MessageContext MessageContext;

    public async Task<object?> HandleMessageAsync(MessageContext messageContext, CancellationToken cancellationToken)
    {
        MessageContext = messageContext;
        return await HandleMessageAsync((T)messageContext.RawMessage.JsonObject.Deserialize(typeof(T)), cancellationToken);
    }

    public abstract Task<object?> HandleMessageAsync(T message, CancellationToken cancellationToken);

    public async Task SendRequestAsync<TResponse>(object request) where TResponse : class
    {
        await MessageContext.MessageBroker.SendRequestAsync<TResponse>(MessageContext.WebSocket, request);
    }
}
