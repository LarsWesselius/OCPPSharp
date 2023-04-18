namespace OCPPSharp.Messages;
/// <summary>
/// Type of message to be triggered.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum MessageTriggerEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"BootNotification")]
    BootNotification = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"LogStatusNotification")]
    LogStatusNotification = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"FirmwareStatusNotification")]
    FirmwareStatusNotification = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Heartbeat")]
    Heartbeat = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"MeterValues")]
    MeterValues = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"SignChargingStationCertificate")]
    SignChargingStationCertificate = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"SignV2GCertificate")]
    SignV2GCertificate = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"StatusNotification")]
    StatusNotification = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"TransactionEvent")]
    TransactionEvent = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"SignCombinedCertificate")]
    SignCombinedCertificate = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"PublishFirmwareStatusNotification")]
    PublishFirmwareStatusNotification = 10,


}