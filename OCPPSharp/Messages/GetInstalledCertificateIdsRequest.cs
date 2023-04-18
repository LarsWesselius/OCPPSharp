namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class GetInstalledCertificateIdsRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Indicates the type of certificates requested. When omitted, all certificate types are requested.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("certificateType")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   

    // TODO(system.text.json): Add string enum item converter
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<GetCertificateIdUseEnumType> CertificateType { get; set; }


}