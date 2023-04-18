namespace OCPPSharp.Messages;
/// <summary>
/// Reason the Charging Station sends this message to the CSMS
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum TriggerReasonEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Authorized")]
    Authorized = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"CablePluggedIn")]
    CablePluggedIn = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"ChargingRateChanged")]
    ChargingRateChanged = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"ChargingStateChanged")]
    ChargingStateChanged = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Deauthorized")]
    Deauthorized = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"EnergyLimitReached")]
    EnergyLimitReached = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"EVCommunicationLost")]
    EVCommunicationLost = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"EVConnectTimeout")]
    EVConnectTimeout = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"MeterValueClock")]
    MeterValueClock = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"MeterValuePeriodic")]
    MeterValuePeriodic = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"TimeLimitReached")]
    TimeLimitReached = 10,


    [System.Runtime.Serialization.EnumMember(Value = @"Trigger")]
    Trigger = 11,


    [System.Runtime.Serialization.EnumMember(Value = @"UnlockCommand")]
    UnlockCommand = 12,


    [System.Runtime.Serialization.EnumMember(Value = @"StopAuthorized")]
    StopAuthorized = 13,


    [System.Runtime.Serialization.EnumMember(Value = @"EVDeparted")]
    EVDeparted = 14,


    [System.Runtime.Serialization.EnumMember(Value = @"EVDetected")]
    EVDetected = 15,


    [System.Runtime.Serialization.EnumMember(Value = @"RemoteStop")]
    RemoteStop = 16,


    [System.Runtime.Serialization.EnumMember(Value = @"RemoteStart")]
    RemoteStart = 17,


    [System.Runtime.Serialization.EnumMember(Value = @"AbnormalCondition")]
    AbnormalCondition = 18,


    [System.Runtime.Serialization.EnumMember(Value = @"SignedDataReceived")]
    SignedDataReceived = 19,


    [System.Runtime.Serialization.EnumMember(Value = @"ResetCommand")]
    ResetCommand = 20,


}