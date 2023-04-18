namespace OCPPSharp.Messages;
/// <summary>
/// Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class AdditionalInfoType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// This field specifies the additional IdToken.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("additionalIdToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(36)]
    public string AdditionalIdToken { get; set; }

    /// <summary>
    /// This defines the type of the additionalIdToken. This is a custom type, so the implementation needs to be agreed upon by all involved parties.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("type")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string Type { get; set; }


}