namespace OCPPSharp.Messages;
/// <summary>
/// Message_ Info
/// <br/>urn:x-enexis:ecdm:uid:2:233264
/// <br/>Contains message details, for a message to be displayed on a Charging Station.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class MessageInfoType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("display")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public ComponentType Display { get; set; }

    /// <summary>
    /// Identified_ Object. MRID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:569198
    /// <br/>Master resource identifier, unique within an exchange context. It is defined within the OCPP context as a positive Integer value (greater or equal to zero).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Id { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("priority")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public MessagePriorityEnumType Priority { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("state")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public MessageStateEnumType State { get; set; }

    /// <summary>
    /// Message_ Info. Start. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569256
    /// <br/>From what date-time should this message be shown. If omitted: directly.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("startDateTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset StartDateTime { get; set; }

    /// <summary>
    /// Message_ Info. End. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569257
    /// <br/>Until what date-time should this message be shown, after this date/time this message SHALL be removed.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("endDateTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset EndDateTime { get; set; }

    /// <summary>
    /// During which transaction shall this message be shown.
    /// <br/>Message SHALL be removed by the Charging Station after transaction has
    /// <br/>ended.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(36)]
    public string TransactionId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("message")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public MessageContentType Message { get; set; } = new MessageContentType();


}