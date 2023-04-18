namespace OCPPSharp.Messages;
/// <summary>
/// Represents a UnitOfMeasure with a multiplier
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class UnitOfMeasureType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Unit of the value. Default = "Wh" if the (default) measurand is an "Energy" type.
    /// <br/>This field SHALL use a value from the list Standardized Units of Measurements in Part 2 Appendices. 
    /// <br/>If an applicable unit is available in that list, otherwise a "custom" unit might be used.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("unit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Unit { get; set; } = "Wh";

    /// <summary>
    /// Multiplier, this value represents the exponent to base 10. I.e. multiplier 3 means 10 raised to the 3rd power. Default is 0.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("multiplier")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Multiplier { get; set; } = 0;


}