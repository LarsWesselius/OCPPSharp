namespace OCPPSharp.Messages;
/// <summary>
/// Indicates the type of the signed certificate that is returned. When omitted the certificate is used for both the 15118 connection (if implemented) and the Charging Station to CSMS connection. This field is required when a typeOfCertificate was included in the &amp;lt;&amp;lt;signcertificaterequest,SignCertificateRequest&amp;gt;&amp;gt; that requested this certificate to be signed AND both the 15118 connection and the Charging Station connection are implemented.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum CertificateSigningUseEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"ChargingStationCertificate")]
    ChargingStationCertificate = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"V2GCertificate")]
    V2GCertificate = 1,


}