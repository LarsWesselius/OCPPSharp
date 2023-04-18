namespace OCPPSharp.Messages;
/// <summary>
/// Cost
/// <br/>urn:x-oca:ocpp:uid:2:233258
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class CostType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("costKind")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public CostKindEnumType CostKind { get; set; }

    /// <summary>
    /// Cost. Amount. Amount
    /// <br/>urn:x-oca:ocpp:uid:1:569244
    /// <br/>The estimated or actual cost per kWh
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("amount")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Amount { get; set; }

    /// <summary>
    /// Cost. Amount_ Multiplier. Integer
    /// <br/>urn:x-oca:ocpp:uid:1:569245
    /// <br/>Values: -3..3, The amountMultiplier defines the exponent to base 10 (dec). The final value is determined by: amount * 10 ^ amountMultiplier
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("amountMultiplier")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int AmountMultiplier { get; set; }


}