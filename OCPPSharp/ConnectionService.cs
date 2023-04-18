using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OCPPSharp.Broker;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;

namespace OCPPSharp;

internal class ConnectionService : IHostedService
{
    private readonly ILogger<ConnectionService> _logger;
    private readonly MessageBroker _messageBroker;
    private CancellationTokenSource _cancellationTokenSource;

    private ConcurrentDictionary<Guid, ClientContext> _clients = new ConcurrentDictionary<Guid, ClientContext>();

    public ConnectionService(ILogger<ConnectionService> logger, MessageBroker messageBroker)
    {
        _logger = logger;
        _messageBroker = messageBroker;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _cancellationTokenSource = new CancellationTokenSource();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _cancellationTokenSource.Cancel();
        return Task.CompletedTask;
    }

    internal async Task ProcessClientAsync(string path, WebSocket socket)
    {
        var id = path.Substring(path.IndexOf('/') + 1);

        var clientContext = new ClientContext()
        {
            WebSocket = socket,
            Id = id,
            Guid = Guid.NewGuid()
        };

        clientContext.ProcessTask = Task.Run(() => ProcessClientData(clientContext, _cancellationTokenSource.Token));

        _clients.TryAdd(clientContext.Guid, clientContext);

        await clientContext.ProcessTask;
    }

    internal async Task ProcessClientData(ClientContext clientContext, CancellationToken cancellationToken)
    {
        byte[] buffer = new byte[1024 * 4];
        var memoryStream = new MemoryStream(buffer.Length);
        var arraySegment = new ArraySegment<byte>(buffer);

        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var receiveResult = await clientContext.WebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                if (receiveResult.CloseStatus.HasValue)
                {
                    _logger.LogDebug($"Web socket {clientContext.Id} closed by client");
                    break;
                }

                memoryStream.Write(buffer, 0, receiveResult.Count);

                if (receiveResult.EndOfMessage)
                {
                    var messageSegment = new ArraySegment<byte>(memoryStream.ToArray(), 0, (int)memoryStream.Length);
                    var messageString = Encoding.UTF8.GetString(messageSegment);

                    await _messageBroker.HandleMessageAsync(messageString, clientContext, cancellationToken);

                    memoryStream.Dispose();
                    memoryStream = new MemoryStream(buffer.Length);
                }

                await Task.Delay(1).ConfigureAwait(false);
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            memoryStream.Dispose();
        }

        if (clientContext.WebSocket.State == WebSocketState.Open)
        {
            try
            {
                CancellationTokenSource newCts = new CancellationTokenSource();
                newCts.CancelAfter(2000);
                await clientContext.WebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Server shutdown", newCts.Token);
            }
            catch (Exception)
            {
                // Don't care
            }
        }

        _clients.TryRemove(clientContext.Guid, out _);
    }
}
