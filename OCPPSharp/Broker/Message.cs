using OCPPSharp.Messages;
using System.Net.WebSockets;
using System.Text.Json.Nodes;

namespace OCPPSharp.Broker;

public class Message
{
    public MessageType MessageType { get; set; }
    public string Action { get; set; }
    public string MessageId { get; set; }

    public JsonObject JsonObject { get; set; }
}

public class MessageContext
{
    public Message RawMessage { get; set; }
    public WebSocket WebSocket { get; set; }
    public string ClientId { get; set; }
    public MessageBroker MessageBroker { get; internal set; }
}
