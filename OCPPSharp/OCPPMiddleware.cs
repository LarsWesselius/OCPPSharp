using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OCPPSharp;

internal class OCPPMiddleware
{
    public const string SupportedOCPPVersion = "ocpp2.0.1";

    private readonly RequestDelegate _next;
    private readonly OCPPConfiguration _configuration;
    private readonly ILogger<OCPPMiddleware> _logger;
    private readonly ConnectionService _connectionService;

    public OCPPMiddleware(RequestDelegate next, OCPPConfiguration configuration, ILogger<OCPPMiddleware> logger, ConnectionService connectionService)
    {
        _next = next;
        _configuration = configuration;
        _logger = logger;
        _connectionService = connectionService;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogTrace($"Validating path {context.Request.Path}");
        if (!context.Request.Path.StartsWithSegments(_configuration.Path, StringComparison.OrdinalIgnoreCase))
        {
            _logger.LogTrace($"OCPP: Path does not match");
            await _next(context);
            return;
        }
        _logger.LogTrace($"Path matches, handling this request.");

        if (!context.WebSockets.IsWebSocketRequest)
        {
            _logger.LogTrace($"Not a web socket request, returning 400");
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            return;
        }

        _logger.LogTrace($"This is a web socket request");

        var socket = await context.WebSockets.AcceptWebSocketAsync(SupportedOCPPVersion);
        await Task.Run(async () => await _connectionService.ProcessClientAsync(context.Request.Path, socket)).ConfigureAwait(false);
    }
}
