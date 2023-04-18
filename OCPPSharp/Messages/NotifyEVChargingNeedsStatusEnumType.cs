namespace OCPPSharp.Messages;
/// <summary>
/// Returns whether the CSMS has been able to process the message successfully. It does not imply that the evChargingNeeds can be met with the current charging profile.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum NotifyEVChargingNeedsStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Processing")]
    Processing = 2,


}