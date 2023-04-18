namespace OCPPSharp.Messages;
/// <summary>
/// Specifies the event notification type of the message.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum EventNotificationEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"HardWiredNotification")]
    HardWiredNotification = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"HardWiredMonitor")]
    HardWiredMonitor = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"PreconfiguredMonitor")]
    PreconfiguredMonitor = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"CustomMonitor")]
    CustomMonitor = 3,


}