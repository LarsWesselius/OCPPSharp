using System.Net.WebSockets;

namespace OCPPSharp;

internal class ClientContext
{
    public WebSocket WebSocket { get; set; }
    public string Id { get; set; }
    public Task ProcessTask { get; internal set; }
    public Guid Guid { get; internal set; }
}