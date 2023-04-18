namespace OCPPSharp.Messages;
/// <summary>
/// Attribute data of a variable.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class VariableAttributeType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("type")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public AttributeEnumType Type { get; set; }

    /// <summary>
    /// Value of the attribute. May only be omitted when mutability is set to 'WriteOnly'.
    /// <br/>
    /// <br/>The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("value")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(2500)]
    public string Value { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("mutability")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public MutabilityEnumType Mutability { get; set; }

    /// <summary>
    /// If true, value will be persistent across system reboots or power down. Default when omitted is false.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("persistent")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Persistent { get; set; } = false;

    /// <summary>
    /// If true, value that will never be changed by the Charging Station at runtime. Default when omitted is false.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("constant")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool Constant { get; set; } = false;


}