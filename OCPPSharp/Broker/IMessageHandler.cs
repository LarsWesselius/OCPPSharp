namespace OCPPSharp.Broker;

public interface IMessageHandler
{
    Task<object?> HandleMessageAsync(MessageContext messageContext, CancellationToken cancellationToken);
}
