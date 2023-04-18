namespace OCPPSharp.Messages;
/// <summary>
/// This contains the current status of the Connector.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ConnectorStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Available")]
    Available = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Occupied")]
    Occupied = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Reserved")]
    Reserved = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Unavailable")]
    Unavailable = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Faulted")]
    Faulted = 4,


}