namespace OCPPSharp.Messages;
/// <summary>
/// This contains the progress status of the publishfirmware
/// <br/>installation.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum PublishFirmwareStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
    Idle = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadScheduled")]
    DownloadScheduled = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Downloading")]
    Downloading = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Downloaded")]
    Downloaded = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Published")]
    Published = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadFailed")]
    DownloadFailed = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadPaused")]
    DownloadPaused = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"InvalidChecksum")]
    InvalidChecksum = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"ChecksumVerified")]
    ChecksumVerified = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"PublishFailed")]
    PublishFailed = 9,


}