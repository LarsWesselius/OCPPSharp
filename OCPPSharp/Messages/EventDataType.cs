namespace OCPPSharp.Messages;
/// <summary>
/// Class to report an event notification for a component-variable.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class EventDataType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identifies the event. This field can be referred to as a cause by other events.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("eventId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EventId { get; set; }

    /// <summary>
    /// Timestamp of the moment the report was generated.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("timestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset Timestamp { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("trigger")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public EventTriggerEnumType Trigger { get; set; }

    /// <summary>
    /// Refers to the Id of an event that is considered to be the cause for this event.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("cause")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Cause { get; set; }

    /// <summary>
    /// Actual value (_attributeType_ Actual) of the variable.
    /// <br/>
    /// <br/>The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("actualValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(2500)]
    public string ActualValue { get; set; }

    /// <summary>
    /// Technical (error) code as reported by component.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("techCode")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string TechCode { get; set; }

    /// <summary>
    /// Technical detail information as reported by component.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("techInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(500)]
    public string TechInfo { get; set; }

    /// <summary>
    /// _Cleared_ is set to true to report the clearing of a monitored situation, i.e. a 'return to normal'. 
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("cleared")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Cleared { get; set; }

    /// <summary>
    /// If an event notification is linked to a specific transaction, this field can be used to specify its transactionId.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(36)]
    public string TransactionId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("component")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public ComponentType Component { get; set; } = new ComponentType();

    /// <summary>
    /// Identifies the VariableMonitoring which triggered the event.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("variableMonitoringId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int VariableMonitoringId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("eventNotificationType")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public EventNotificationEnumType EventNotificationType { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("variable")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public VariableType Variable { get; set; } = new VariableType();


}