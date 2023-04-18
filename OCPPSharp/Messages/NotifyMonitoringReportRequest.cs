namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class NotifyMonitoringReportRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("monitor")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<MonitoringDataType> Monitor { get; set; }

    /// <summary>
    /// The id of the GetMonitoringRequest that requested this report.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }

    /// <summary>
    /// “to be continued” indicator. Indicates whether another part of the monitoringData follows in an upcoming notifyMonitoringReportRequest message. Default value when omitted is false.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("tbc")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Tbc { get; set; } = false;

    /// <summary>
    /// Sequence number of this message. First message starts at 0.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("seqNo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int SeqNo { get; set; }

    /// <summary>
    /// Timestamp of the moment this message was generated at the Charging Station.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("generatedAt")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset GeneratedAt { get; set; }


}