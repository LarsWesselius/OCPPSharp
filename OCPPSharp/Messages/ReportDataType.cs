namespace OCPPSharp.Messages;
/// <summary>
/// Class to report components, variables and variable attributes and characteristics.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ReportDataType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("component")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public ComponentType Component { get; set; } = new ComponentType();


    [System.Text.Json.Serialization.JsonPropertyName("variable")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public VariableType Variable { get; set; } = new VariableType();


    [System.Text.Json.Serialization.JsonPropertyName("variableAttribute")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(4)]
    public System.Collections.Generic.ICollection<VariableAttributeType> VariableAttribute { get; set; } = new System.Collections.ObjectModel.Collection<VariableAttributeType>();


    [System.Text.Json.Serialization.JsonPropertyName("variableCharacteristics")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public VariableCharacteristicsType VariableCharacteristics { get; set; }


}