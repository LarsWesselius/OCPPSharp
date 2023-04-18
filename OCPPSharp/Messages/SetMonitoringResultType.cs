namespace OCPPSharp.Messages;
/// <summary>
/// Class to hold result of SetVariableMonitoring request.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SetMonitoringResultType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Id given to the VariableMonitor by the Charging Station. The Id is only returned when status is accepted. Installed VariableMonitors should have unique id's but the id's of removed Installed monitors should have unique id's but the id's of removed monitors MAY be reused.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Id { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("statusInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public StatusInfoType StatusInfo { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("status")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public SetMonitoringStatusEnumType Status { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("type")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public MonitorEnumType Type { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("component")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public ComponentType Component { get; set; } = new ComponentType();


    [System.Text.Json.Serialization.JsonPropertyName("variable")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public VariableType Variable { get; set; } = new VariableType();

    /// <summary>
    /// The severity that will be assigned to an event that is triggered by this monitor. The severity range is 0-9, with 0 as the highest and 9 as the lowest severity level.
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
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("severity")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Severity { get; set; }


}