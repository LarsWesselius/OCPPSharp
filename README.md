# OCPPSharp
Super simple OCPP 2.0(.1) server for use in a web app.

```csharp
using OCPPSharp;
using OCPPSharp.Broker;
using OCPPSharp.Messages;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOCPPServer(x => x
    .WithPath("ocpp")
    .DetectMessageHandlersInAssembly(typeof(Program).Assembly));
var app = builder.Build();

app.UseWebSockets();
app.UseOCPPServer();
app.Run();

public class BootNotificationMessageHandler : MessageHandler<BootNotificationRequest>
{
    private readonly ILogger<BootNotificationMessageHandler> _logger;

    public BootNotificationMessageHandler(ILogger<BootNotificationMessageHandler> logger)
    {
        _logger = logger;
    }

    public override async Task<object?> HandleMessageAsync(BootNotificationRequest message, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Boot notification received! {message.ChargingStation.VendorName} {message.ChargingStation.Model} came knocking!");
        return new BootNotificationResponse()
        {
            Status = RegistrationStatusEnumType.Accepted,
            Interval = 60 * 1000
        };
    }
}
```
 
