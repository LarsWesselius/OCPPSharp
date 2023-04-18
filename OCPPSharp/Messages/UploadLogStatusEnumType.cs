namespace OCPPSharp.Messages;
/// <summary>
/// This contains the status of the log upload.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum UploadLogStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"BadMessage")]
    BadMessage = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
    Idle = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"NotSupportedOperation")]
    NotSupportedOperation = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"PermissionDenied")]
    PermissionDenied = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Uploaded")]
    Uploaded = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"UploadFailure")]
    UploadFailure = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"Uploading")]
    Uploading = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"AcceptedCanceled")]
    AcceptedCanceled = 7,


}