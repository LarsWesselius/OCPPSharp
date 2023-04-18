namespace OCPPSharp.Messages;
/// <summary>
/// Sales_ Tariff
/// <br/>urn:x-oca:ocpp:uid:2:233272
/// <br/>NOTE: This dataType is based on dataTypes from &amp;lt;&amp;lt;ref-ISOIEC15118-2,ISO 15118-2&amp;gt;&amp;gt;.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SalesTariffType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identified_ Object. MRID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:569198
    /// <br/>SalesTariff identifier used to identify one sales tariff. An SAID remains a unique identifier for one schedule throughout a charging session.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Id { get; set; }

    /// <summary>
    /// Sales_ Tariff. Sales. Tariff_ Description
    /// <br/>urn:x-oca:ocpp:uid:1:569283
    /// <br/>A human readable title/short description of the sales tariff e.g. for HMI display purposes.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("salesTariffDescription")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(32)]
    public string SalesTariffDescription { get; set; }

    /// <summary>
    /// Sales_ Tariff. Num_ E_ Price_ Levels. Counter
    /// <br/>urn:x-oca:ocpp:uid:1:569284
    /// <br/>Defines the overall number of distinct price levels used across all provided SalesTariff elements.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("numEPriceLevels")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int NumEPriceLevels { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("salesTariffEntry")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(1024)]
    public System.Collections.Generic.ICollection<SalesTariffEntryType> SalesTariffEntry { get; set; } = new System.Collections.ObjectModel.Collection<SalesTariffEntryType>();


}