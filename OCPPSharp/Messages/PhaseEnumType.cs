namespace OCPPSharp.Messages;
/// <summary>
/// Sampled_ Value. Phase. Phase_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569264
/// <br/>Indicates how the measured value is to be interpreted. For instance between L1 and neutral (L1-N) Please note that not all values of phase are applicable to all Measurands. When phase is absent, the measured value is interpreted as an overall value.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum PhaseEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"L1")]
    L1 = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"L2")]
    L2 = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"L3")]
    L3 = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"N")]
    N = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"L1-N")]
    L1N = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"L2-N")]
    L2N = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"L3-N")]
    L3N = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"L1-L2")]
    L1L2 = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"L2-L3")]
    L2L3 = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"L3-L1")]
    L3L1 = 9,


}