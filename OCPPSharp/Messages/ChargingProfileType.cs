namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Profile
/// <br/>urn:x-oca:ocpp:uid:2:233255
/// <br/>A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingProfileType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identified_ Object. MRID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:569198
    /// <br/>Id of ChargingProfile.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Id { get; set; }

    /// <summary>
    /// Charging_ Profile. Stack_ Level. Counter
    /// <br/>urn:x-oca:ocpp:uid:1:569230
    /// <br/>Value determining level in hierarchy stack of profiles. Higher values have precedence over lower values. Lowest level is 0.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("stackLevel")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int StackLevel { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfilePurpose")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfileKind")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingProfileKindEnumType ChargingProfileKind { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("recurrencyKind")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public RecurrencyKindEnumType RecurrencyKind { get; set; }

    /// <summary>
    /// Charging_ Profile. Valid_ From. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569234
    /// <br/>Point in time at which the profile starts to be valid. If absent, the profile is valid as soon as it is received by the Charging Station.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("validFrom")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset ValidFrom { get; set; }

    /// <summary>
    /// Charging_ Profile. Valid_ To. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569235
    /// <br/>Point in time at which the profile stops to be valid. If absent, the profile is valid until it is replaced by another profile.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("validTo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset ValidTo { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingSchedule")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(3)]
    public System.Collections.Generic.ICollection<ChargingScheduleType> ChargingSchedule { get; set; } = new System.Collections.ObjectModel.Collection<ChargingScheduleType>();

    /// <summary>
    /// SHALL only be included if ChargingProfilePurpose is set to TxProfile. The transactionId is used to match the profile to a specific transaction.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(36)]
    public string TransactionId { get; set; }


}