namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class StatusNotificationRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// The time for which the status is reported. If absent time of receipt of the message will be assumed.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("timestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset Timestamp { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("connectorStatus")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ConnectorStatusEnumType ConnectorStatus { get; set; }

    /// <summary>
    /// The id of the EVSE to which the connector belongs for which the the status is reported.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvseId { get; set; }

    /// <summary>
    /// The id of the connector within the EVSE for which the status is reported.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("connectorId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int ConnectorId { get; set; }


}