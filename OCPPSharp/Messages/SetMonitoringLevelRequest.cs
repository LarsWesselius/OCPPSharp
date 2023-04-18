namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SetMonitoringLevelRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// The Charging Station SHALL only report events with a severity number lower than or equal to this severity.
    /// <br/>The severity range is 0-9, with 0 as the highest and 9 as the lowest severity level.
    /// <br/>
    /// <br/>The severity levels have the following meaning: +
    /// <br/>*0-Danger* +
    /// <br/>Indicates lives are potentially in danger. Urgent attention is needed and action should be taken immediately. +
    /// <br/>*1-Hardware Failure* +
    /// <br/>Indicates that the Charging Station is unable to continue regular operations due to Hardware issues. Action is required. +
    /// <br/>*2-System Failure* +
    /// <br/>Indicates that the Charging Station is unable to continue regular operations due to software or minor hardware issues. Action is required. +
    /// <br/>*3-Critical* +
    /// <br/>Indicates a critical error. Action is required. +
    /// <br/>*4-Error* +
    /// <br/>Indicates a non-urgent error. Action is required. +
    /// <br/>*5-Alert* +
    /// <br/>Indicates an alert event. Default severity for any type of monitoring event.  +
    /// <br/>*6-Warning* +
    /// <br/>Indicates a warning event. Action may be required. +
    /// <br/>*7-Notice* +
    /// <br/>Indicates an unusual event. No immediate action is required. +
    /// <br/>*8-Informational* +
    /// <br/>Indicates a regular operational event. May be used for reporting, measuring throughput, etc. No action is required. +
    /// <br/>*9-Debug* +
    /// <br/>Indicates information useful to developers for debugging, not useful during operations.
    /// <br/>
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("severity")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Severity { get; set; }


}