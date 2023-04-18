namespace OCPPSharp.Messages;
/// <summary>
/// This field indicates whether the Charging Station was able to accept the request.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum UpdateFirmwareStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"AcceptedCanceled")]
    AcceptedCanceled = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"InvalidCertificate")]
    InvalidCertificate = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"RevokedCertificate")]
    RevokedCertificate = 4,


}