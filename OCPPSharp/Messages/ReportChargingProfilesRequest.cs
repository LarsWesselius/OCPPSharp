namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ReportChargingProfilesRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Id used to match the &amp;lt;&amp;lt;getchargingprofilesrequest, GetChargingProfilesRequest&amp;gt;&amp;gt; message with the resulting ReportChargingProfilesRequest messages. When the CSMS provided a requestId in the &amp;lt;&amp;lt;getchargingprofilesrequest, GetChargingProfilesRequest&amp;gt;&amp;gt;, this field SHALL contain the same value.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingLimitSource")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingLimitSourceEnumType ChargingLimitSource { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfile")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<ChargingProfileType> ChargingProfile { get; set; } = new System.Collections.ObjectModel.Collection<ChargingProfileType>();

    /// <summary>
    /// To Be Continued. Default value when omitted: false. false indicates that there are no further messages as part of this report.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("tbc")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Tbc { get; set; } = false;

    /// <summary>
    /// The evse to which the charging profile applies. If evseId = 0, the message contains an overall limit for the Charging Station.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvseId { get; set; }


}