namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class CertificateHashDataType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("hashAlgorithm")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public HashAlgorithmEnumType HashAlgorithm { get; set; }

    /// <summary>
    /// Hashed value of the Issuer DN (Distinguished Name).
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("issuerNameHash")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(128)]
    public string IssuerNameHash { get; set; }

    /// <summary>
    /// Hashed value of the issuers public key
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("issuerKeyHash")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(128)]
    public string IssuerKeyHash { get; set; }

    /// <summary>
    /// The serial number of the certificate.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("serialNumber")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(40)]
    public string SerialNumber { get; set; }


}