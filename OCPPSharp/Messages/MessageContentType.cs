namespace OCPPSharp.Messages;
/// <summary>
/// Message_ Content
/// <br/>urn:x-enexis:ecdm:uid:2:234490
/// <br/>Contains message details, for a message to be displayed on a Charging Station.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class MessageContentType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("format")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public MessageFormatEnumType Format { get; set; }

    /// <summary>
    /// Message_ Content. Language. Language_ Code
    /// <br/>urn:x-enexis:ecdm:uid:1:570849
    /// <br/>Message language identifier. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("language")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(8)]
    public string Language { get; set; }

    /// <summary>
    /// Message_ Content. Content. Message
    /// <br/>urn:x-enexis:ecdm:uid:1:570852
    /// <br/>Message contents.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("content")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Content { get; set; }


}