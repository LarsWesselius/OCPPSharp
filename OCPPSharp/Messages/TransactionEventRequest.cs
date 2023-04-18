namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class TransactionEventRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("eventType")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public TransactionEventEnumType EventType { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("meterValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; }

    /// <summary>
    /// The date and time at which this transaction event occurred.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("timestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset Timestamp { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("triggerReason")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public TriggerReasonEnumType TriggerReason { get; set; }

    /// <summary>
    /// Incremental sequence number, helps with determining if all messages of a transaction have been received.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("seqNo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int SeqNo { get; set; }

    /// <summary>
    /// Indication that this transaction event happened when the Charging Station was offline. Default = false, meaning: the event occurred when the Charging Station was online.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("offline")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Offline { get; set; } = false;

    /// <summary>
    /// If the Charging Station is able to report the number of phases used, then it SHALL provide it. When omitted the CSMS may be able to determine the number of phases used via device management.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("numberOfPhasesUsed")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int NumberOfPhasesUsed { get; set; }

    /// <summary>
    /// The maximum current of the connected cable in Ampere (A).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("cableMaxCurrent")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int CableMaxCurrent { get; set; }

    /// <summary>
    /// This contains the Id of the reservation that terminates as a result of this transaction.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("reservationId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int ReservationId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("transactionInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public TransactionType TransactionInfo { get; set; } = new TransactionType();


    [System.Text.Json.Serialization.JsonPropertyName("evse")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public EVSEType Evse { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("idToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public IdTokenType IdToken { get; set; }


}