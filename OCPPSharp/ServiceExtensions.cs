using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OCPPSharp.Broker;

namespace OCPPSharp;
public static class ServiceExtensions
{
    public static void AddOCPPServer(this IServiceCollection services, Action<OCPPConfigurationBuilder> options)
    {
        var config = new OCPPConfigurationBuilder();

        options(config);

        var builtConfig = config.Build();
        services.AddSingleton(builtConfig);

        services.AddSingleton<ConnectionService>();
        services.AddHostedService(x => x.GetRequiredService<ConnectionService>());
        services.AddSingleton<MessageBroker>();

        DetectMessageHandlers(builtConfig, services);
    }

    private static void DetectMessageHandlers(OCPPConfiguration config, IServiceCollection services)
    {
        var messageHandlerType = typeof(IMessageHandler);
        var types = config.DetectHandlerAssemblies.SelectMany(z => z.GetTypes()).Where(z => messageHandlerType.IsAssignableFrom(z) && z.IsClass && !z.IsAbstract && z.BaseType != null);

        foreach (var t in types)
            services.AddScoped(t.BaseType, t);
    }

    public static IApplicationBuilder UseOCPPServer(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<OCPPMiddleware>();
    }
}
