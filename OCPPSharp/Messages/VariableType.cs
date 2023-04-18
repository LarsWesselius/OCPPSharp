namespace OCPPSharp.Messages;
/// <summary>
/// Reference key to a component-variable.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class VariableType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Name of the variable. Name should be taken from the list of standardized variable names whenever possible. Case Insensitive. strongly advised to use Camel Case.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("name")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string Name { get; set; }

    /// <summary>
    /// Name of instance in case the variable exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("instance")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string Instance { get; set; }


}