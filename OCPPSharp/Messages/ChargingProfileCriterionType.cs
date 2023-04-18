namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Profile
/// <br/>urn:x-oca:ocpp:uid:2:233255
/// <br/>A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingProfileCriterionType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfilePurpose")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }

    /// <summary>
    /// Charging_ Profile. Stack_ Level. Counter
    /// <br/>urn:x-oca:ocpp:uid:1:569230
    /// <br/>Value determining level in hierarchy stack of profiles. Higher values have precedence over lower values. Lowest level is 0.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("stackLevel")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int StackLevel { get; set; }

    /// <summary>
    /// List of all the chargingProfileIds requested. Any ChargingProfile that matches one of these profiles will be reported. If omitted, the Charging Station SHALL not filter on chargingProfileId. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-charging-profile-entries,ChargingProfileEntries.maxLimit&amp;gt;&amp;gt;
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("chargingProfileId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<int> ChargingProfileId { get; set; }

    /// <summary>
    /// For which charging limit sources, charging profiles SHALL be reported. If omitted, the Charging Station SHALL not filter on chargingLimitSource.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("chargingLimitSource")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   

    // TODO(system.text.json): Add string enum item converter
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(4)]
    public System.Collections.Generic.ICollection<ChargingLimitSourceEnumType> ChargingLimitSource { get; set; }


}