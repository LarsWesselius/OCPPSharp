namespace OCPPSharp.Messages;
/// <summary>
/// This indicates whether the Charging Station is able to display the message.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum DisplayMessageStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"NotSupportedMessageFormat")]
    NotSupportedMessageFormat = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"NotSupportedPriority")]
    NotSupportedPriority = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"NotSupportedState")]
    NotSupportedState = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"UnknownTransaction")]
    UnknownTransaction = 5,


}