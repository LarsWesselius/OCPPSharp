namespace OCPPSharp.Messages;
/// <summary>
/// Status is OK if a value could be returned. Otherwise this will indicate the reason why a value could not be returned.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum SetMonitoringStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"UnknownComponent")]
    UnknownComponent = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"UnknownVariable")]
    UnknownVariable = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"UnsupportedMonitorType")]
    UnsupportedMonitorType = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"Duplicate")]
    Duplicate = 5,


}