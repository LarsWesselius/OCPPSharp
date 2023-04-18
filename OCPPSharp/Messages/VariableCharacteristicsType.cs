namespace OCPPSharp.Messages;
/// <summary>
/// Fixed read-only parameters of a variable.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class VariableCharacteristicsType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Unit of the variable. When the transmitted value has a unit, this field SHALL be included.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("unit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(16)]
    public string Unit { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("dataType")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public DataEnumType DataType { get; set; }

    /// <summary>
    /// Minimum possible value of this variable.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("minLimit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public double MinLimit { get; set; }

    /// <summary>
    /// Maximum possible value of this variable. When the datatype of this Variable is String, OptionList, SequenceList or MemberList, this field defines the maximum length of the (CSV) string.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("maxLimit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public double MaxLimit { get; set; }

    /// <summary>
    /// Allowed values when variable is Option/Member/SequenceList. 
    /// <br/>
    /// <br/>* OptionList: The (Actual) Variable value must be a single value from the reported (CSV) enumeration list.
    /// <br/>
    /// <br/>* MemberList: The (Actual) Variable value  may be an (unordered) (sub-)set of the reported (CSV) valid values list.
    /// <br/>
    /// <br/>* SequenceList: The (Actual) Variable value  may be an ordered (priority, etc)  (sub-)set of the reported (CSV) valid values.
    /// <br/>
    /// <br/>This is a comma separated list.
    /// <br/>
    /// <br/>The Configuration Variable &amp;lt;&amp;lt;configkey-configuration-value-size,ConfigurationValueSize&amp;gt;&amp;gt; can be used to limit SetVariableData.attributeValue and VariableCharacteristics.valueList. The max size of these values will always remain equal. 
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("valuesList")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string ValuesList { get; set; }

    /// <summary>
    /// Flag indicating if this variable supports monitoring. 
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("supportsMonitoring")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public bool SupportsMonitoring { get; set; }


}