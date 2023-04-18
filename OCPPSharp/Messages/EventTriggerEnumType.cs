namespace OCPPSharp.Messages;
/// <summary>
/// Type of monitor that triggered this event, e.g. exceeding a threshold value.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum EventTriggerEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Alerting")]
    Alerting = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Delta")]
    Delta = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Periodic")]
    Periodic = 2,


}