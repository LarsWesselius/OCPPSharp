namespace OCPPSharp.Messages;
/// <summary>
/// This indicates whether the Charging Station has unlocked the connector.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum UnlockStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Unlocked")]
    Unlocked = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"UnlockFailed")]
    UnlockFailed = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"OngoingAuthorizedTransaction")]
    OngoingAuthorizedTransaction = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"UnknownConnector")]
    UnknownConnector = 3,


}