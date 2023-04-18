namespace OCPPSharp.Messages;
/// <summary>
/// Consumption_ Cost
/// <br/>urn:x-oca:ocpp:uid:2:233259
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ConsumptionCostType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Consumption_ Cost. Start_ Value. Numeric
    /// <br/>urn:x-oca:ocpp:uid:1:569246
    /// <br/>The lowest level of consumption that defines the starting point of this consumption block. The block interval extends to the start of the next interval.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("startValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public double StartValue { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("cost")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(3)]
    public System.Collections.Generic.ICollection<CostType> Cost { get; set; } = new System.Collections.ObjectModel.Collection<CostType>();


}