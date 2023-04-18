namespace OCPPSharp.Messages;
/// <summary>
/// Transaction. Stopped_ Reason. EOT_ Reason_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569413
/// <br/>This contains the reason why the transaction was stopped. MAY only be omitted when Reason is "Local".
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ReasonEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"DeAuthorized")]
    DeAuthorized = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"EmergencyStop")]
    EmergencyStop = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"EnergyLimitReached")]
    EnergyLimitReached = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"EVDisconnected")]
    EVDisconnected = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"GroundFault")]
    GroundFault = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"ImmediateReset")]
    ImmediateReset = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"Local")]
    Local = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"LocalOutOfCredit")]
    LocalOutOfCredit = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"MasterPass")]
    MasterPass = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"Other")]
    Other = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"OvercurrentFault")]
    OvercurrentFault = 10,


    [System.Runtime.Serialization.EnumMember(Value = @"PowerLoss")]
    PowerLoss = 11,


    [System.Runtime.Serialization.EnumMember(Value = @"PowerQuality")]
    PowerQuality = 12,


    [System.Runtime.Serialization.EnumMember(Value = @"Reboot")]
    Reboot = 13,


    [System.Runtime.Serialization.EnumMember(Value = @"Remote")]
    Remote = 14,


    [System.Runtime.Serialization.EnumMember(Value = @"SOCLimitReached")]
    SOCLimitReached = 15,


    [System.Runtime.Serialization.EnumMember(Value = @"StoppedByEV")]
    StoppedByEV = 16,


    [System.Runtime.Serialization.EnumMember(Value = @"TimeLimitReached")]
    TimeLimitReached = 17,


    [System.Runtime.Serialization.EnumMember(Value = @"Timeout")]
    Timeout = 18,


}