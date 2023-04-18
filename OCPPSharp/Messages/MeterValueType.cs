namespace OCPPSharp.Messages;
/// <summary>
/// Meter_ Value
/// <br/>urn:x-oca:ocpp:uid:2:233265
/// <br/>Collection of one or more sampled values in MeterValuesRequest and TransactionEvent. All sampled values in a MeterValue are sampled at the same point in time.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class MeterValueType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("sampledValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<SampledValueType> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValueType>();

    /// <summary>
    /// Meter_ Value. Timestamp. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569259
    /// <br/>Timestamp for measured value(s).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("timestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset Timestamp { get; set; }


}