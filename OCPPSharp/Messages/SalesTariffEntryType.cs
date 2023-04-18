namespace OCPPSharp.Messages;
/// <summary>
/// Sales_ Tariff_ Entry
/// <br/>urn:x-oca:ocpp:uid:2:233271
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SalesTariffEntryType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("relativeTimeInterval")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public RelativeTimeIntervalType RelativeTimeInterval { get; set; } = new RelativeTimeIntervalType();

    /// <summary>
    /// Sales_ Tariff_ Entry. E_ Price_ Level. Unsigned_ Integer
    /// <br/>urn:x-oca:ocpp:uid:1:569281
    /// <br/>Defines the price level of this SalesTariffEntry (referring to NumEPriceLevels). Small values for the EPriceLevel represent a cheaper TariffEntry. Large values for the EPriceLevel represent a more expensive TariffEntry.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("ePriceLevel")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
    public int EPriceLevel { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("consumptionCost")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(3)]
    public System.Collections.Generic.ICollection<ConsumptionCostType> ConsumptionCost { get; set; }


}