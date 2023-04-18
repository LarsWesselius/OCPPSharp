namespace OCPPSharp.Messages;
/// <summary>
/// This indicates whether the Charging Station has successfully received and applied the update of the Local Authorization List.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum SendLocalListStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
    Failed = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"VersionMismatch")]
    VersionMismatch = 2,


}