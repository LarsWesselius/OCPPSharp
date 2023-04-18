namespace OCPPSharp.Messages;
/// <summary>
/// The type of this monitor, e.g. a threshold, delta or periodic monitor. 
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum MonitorEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"UpperThreshold")]
    UpperThreshold = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"LowerThreshold")]
    LowerThreshold = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Delta")]
    Delta = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Periodic")]
    Periodic = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"PeriodicClockAligned")]
    PeriodicClockAligned = 4,


}