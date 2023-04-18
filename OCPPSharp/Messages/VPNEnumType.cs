namespace OCPPSharp.Messages;
/// <summary>
/// VPN. Type. VPN_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569277
/// <br/>Type of VPN
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum VPNEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"IKEv2")]
    IKEv2 = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"IPSec")]
    IPSec = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"L2TP")]
    L2TP = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"PPTP")]
    PPTP = 3,


}