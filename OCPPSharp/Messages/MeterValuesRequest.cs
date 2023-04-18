namespace OCPPSharp.Messages;
/// <summary>
/// Request_ Body
/// <br/>urn:x-enexis:ecdm:uid:2:234744
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class MeterValuesRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Request_ Body. EVSEID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:571101
    /// <br/>This contains a number (&amp;gt;0) designating an EVSE of the Charging Station. ‘0’ (zero) is used to designate the main power meter.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvseId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("meterValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; } = new System.Collections.ObjectModel.Collection<MeterValueType>();


}