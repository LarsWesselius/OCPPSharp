namespace OCPPSharp.Messages;
/// <summary>
/// Indicates whether the Local Controller succeeded in unpublishing the firmware.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum UnpublishFirmwareStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"DownloadOngoing")]
    DownloadOngoing = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"NoFirmware")]
    NoFirmware = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Unpublished")]
    Unpublished = 2,


}