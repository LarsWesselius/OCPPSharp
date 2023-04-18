namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Profile
/// <br/>urn:x-oca:ocpp:uid:2:233255
/// <br/>A ChargingProfile consists of a ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ClearChargingProfileType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identified_ Object. MRID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:569198
    /// <br/>Specifies the id of the EVSE for which to clear charging profiles. An evseId of zero (0) specifies the charging profile for the overall Charging Station. Absence of this parameter means the clearing applies to all charging profiles that match the other criteria in the request.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int EvseId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfilePurpose")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }

    /// <summary>
    /// Charging_ Profile. Stack_ Level. Counter
    /// <br/>urn:x-oca:ocpp:uid:1:569230
    /// <br/>Specifies the stackLevel for which charging profiles will be cleared, if they meet the other criteria in the request.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("stackLevel")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int StackLevel { get; set; }


}