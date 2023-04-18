namespace OCPPSharp.Messages;
/// <summary>
/// Transaction. State. Transaction_ State_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569419
/// <br/>Current charging state, is required when state
/// <br/>has changed.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ChargingStateEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Charging")]
    Charging = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"EVConnected")]
    EVConnected = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"SuspendedEV")]
    SuspendedEV = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"SuspendedEVSE")]
    SuspendedEVSE = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
    Idle = 4,


}