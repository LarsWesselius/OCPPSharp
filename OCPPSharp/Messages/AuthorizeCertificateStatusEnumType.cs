namespace OCPPSharp.Messages;
/// <summary>
/// Certificate status information. 
/// <br/>- if all certificates are valid: return 'Accepted'.
/// <br/>- if one of the certificates was revoked, return 'CertificateRevoked'.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum AuthorizeCertificateStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"SignatureError")]
    SignatureError = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"CertificateExpired")]
    CertificateExpired = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"CertificateRevoked")]
    CertificateRevoked = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"NoCertificateAvailable")]
    NoCertificateAvailable = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"CertChainError")]
    CertChainError = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"ContractCancelled")]
    ContractCancelled = 6,


}