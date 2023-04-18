namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class CustomerInformationRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("customerCertificate")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CertificateHashDataType CustomerCertificate { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("idToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public IdTokenType IdToken { get; set; }

    /// <summary>
    /// The Id of the request.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }

    /// <summary>
    /// Flag indicating whether the Charging Station should return NotifyCustomerInformationRequest messages containing information about the customer referred to.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("report")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public bool Report { get; set; }

    /// <summary>
    /// Flag indicating whether the Charging Station should clear all information about the customer referred to.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("clear")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public bool Clear { get; set; }

    /// <summary>
    /// A (e.g. vendor specific) identifier of the customer this request refers to. This field contains a custom identifier other than IdToken and Certificate.
    /// <br/>One of the possible identifiers (customerIdentifier, customerIdToken or customerCertificate) should be in the request message.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("customerIdentifier")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(64)]
    public string CustomerIdentifier { get; set; }


}