namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class AuthorizeRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("idToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public IdTokenType IdToken { get; set; } = new IdTokenType();

    /// <summary>
    /// The X.509 certificated presented by EV and encoded in PEM format.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("certificate")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(5500)]
    public string Certificate { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("iso15118CertificateHashData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(4)]
    public System.Collections.Generic.ICollection<OCSPRequestDataType> Iso15118CertificateHashData { get; set; }


}