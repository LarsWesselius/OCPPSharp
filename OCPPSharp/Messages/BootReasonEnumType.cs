namespace OCPPSharp.Messages;
/// <summary>
/// This contains the reason for sending this message to the CSMS.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum BootReasonEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"ApplicationReset")]
    ApplicationReset = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"FirmwareUpdate")]
    FirmwareUpdate = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"LocalReset")]
    LocalReset = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"PowerUp")]
    PowerUp = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"RemoteReset")]
    RemoteReset = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"ScheduledReset")]
    ScheduledReset = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"Triggered")]
    Triggered = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"Unknown")]
    Unknown = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"Watchdog")]
    Watchdog = 8,


}