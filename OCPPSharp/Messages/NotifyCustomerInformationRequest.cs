namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class NotifyCustomerInformationRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// (Part of) the requested data. No format specified in which the data is returned. Should be human readable.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("data")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Data { get; set; }

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
    ///  Timestamp of the moment this message was generated at the Charging Station.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("generatedAt")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset GeneratedAt { get; set; }

    /// <summary>
    /// The Id of the request.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }


}