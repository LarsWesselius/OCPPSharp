using System.Reflection;

namespace OCPPSharp;

internal class OCPPConfiguration
{
    public string Path { get; set; }
    public List<Assembly> DetectHandlerAssemblies { get; set; }
}
