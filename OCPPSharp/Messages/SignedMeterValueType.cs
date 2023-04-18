namespace OCPPSharp.Messages;
/// <summary>
/// Represent a signed version of the meter value.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SignedMeterValueType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Base64 encoded, contains the signed data which might contain more then just the meter value. It can contain information like timestamps, reference to a customer etc.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("signedMeterData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(2500)]
    public string SignedMeterData { get; set; }

    /// <summary>
    /// Method used to create the digital signature.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("signingMethod")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string SigningMethod { get; set; }

    /// <summary>
    /// Method used to encode the meter values before applying the digital signature algorithm.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("encodingMethod")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string EncodingMethod { get; set; }

    /// <summary>
    /// Base64 encoded, sending depends on configuration variable _PublicKeyWithSignedMeterValue_.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("publicKey")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(2500)]
    public string PublicKey { get; set; }


}