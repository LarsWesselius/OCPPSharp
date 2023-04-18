namespace OCPPSharp.Messages;
/// <summary>
/// Returns whether the Charging Station has been able to process the message successfully. This does not guarantee the schedule will be followed to the letter. There might be other constraints the Charging Station may need to take into account.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ChargingProfileStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 1,


}