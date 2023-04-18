using System.Reflection;

namespace OCPPSharp;

public class OCPPConfigurationBuilder
{
    private OCPPConfiguration _configuration;

    public OCPPConfigurationBuilder()
    {
        _configuration = new OCPPConfiguration();
    }

    public OCPPConfigurationBuilder WithPath(string path)
    {
        _configuration.Path = path.StartsWith("/") ? path : $"/{path}";
        return this;
    }

    public OCPPConfigurationBuilder DetectMessageHandlersInAssembly(params Assembly[] assemblies)
    {
        _configuration.DetectHandlerAssemblies ??= new List<Assembly>();
        _configuration.DetectHandlerAssemblies.AddRange(assemblies);
        return this;
    }

    internal OCPPConfiguration Build()
    {
        return _configuration;
    }
}