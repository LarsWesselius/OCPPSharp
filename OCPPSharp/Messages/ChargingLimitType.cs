namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Limit
/// <br/>urn:x-enexis:ecdm:uid:2:234489
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingLimitType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingLimitSource")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingLimitSourceEnumType ChargingLimitSource { get; set; }

    /// <summary>
    /// Charging_ Limit. Is_ Grid_ Critical. Indicator
    /// <br/>urn:x-enexis:ecdm:uid:1:570847
    /// <br/>Indicates whether the charging limit is critical for the grid.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("isGridCritical")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool IsGridCritical { get; set; }


}