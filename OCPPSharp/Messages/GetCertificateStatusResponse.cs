namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class GetCertificateStatusResponse
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("status")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public GetCertificateStatusEnumType Status { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("statusInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public StatusInfoType StatusInfo { get; set; }

    /// <summary>
    /// OCSPResponse class as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;. DER encoded (as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;), and then base64 encoded. MAY only be omitted when status is not Accepted.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("ocspResult")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(5500)]
    public string OcspResult { get; set; }


}