namespace OCPPSharp.Messages;
/// <summary>
/// This contains the progress status of the firmware installation.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum FirmwareStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Downloaded")]
    Downloaded = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadFailed")]
    DownloadFailed = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Downloading")]
    Downloading = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadScheduled")]
    DownloadScheduled = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"DownloadPaused")]
    DownloadPaused = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
    Idle = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"InstallationFailed")]
    InstallationFailed = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"Installing")]
    Installing = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"Installed")]
    Installed = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"InstallRebooting")]
    InstallRebooting = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"InstallScheduled")]
    InstallScheduled = 10,


    [System.Runtime.Serialization.EnumMember(Value = @"InstallVerificationFailed")]
    InstallVerificationFailed = 11,


    [System.Runtime.Serialization.EnumMember(Value = @"InvalidSignature")]
    InvalidSignature = 12,


    [System.Runtime.Serialization.EnumMember(Value = @"SignatureVerified")]
    SignatureVerified = 13,


}