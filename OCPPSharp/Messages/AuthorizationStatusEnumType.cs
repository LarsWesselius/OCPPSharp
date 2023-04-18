namespace OCPPSharp.Messages;
/// <summary>
/// ID_ Token. Status. Authorization_ Status
/// <br/>urn:x-oca:ocpp:uid:1:569372
/// <br/>Current status of the ID Token.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum AuthorizationStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Blocked")]
    Blocked = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"ConcurrentTx")]
    ConcurrentTx = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Expired")]
    Expired = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Invalid")]
    Invalid = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"NoCredit")]
    NoCredit = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"NotAllowedTypeEVSE")]
    NotAllowedTypeEVSE = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"NotAtThisLocation")]
    NotAtThisLocation = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"NotAtThisTime")]
    NotAtThisTime = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"Unknown")]
    Unknown = 9,


}