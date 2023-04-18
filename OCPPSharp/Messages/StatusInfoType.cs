namespace OCPPSharp.Messages;
/// <summary>
/// Element providing more information about the status.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class StatusInfoType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// A predefined code for the reason why the status is returned in this response. The string is case-insensitive.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("reasonCode")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string ReasonCode { get; set; }

    /// <summary>
    /// Additional text to provide detailed information.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("additionalInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string AdditionalInfo { get; set; }


}