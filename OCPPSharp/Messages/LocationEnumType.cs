namespace OCPPSharp.Messages;
/// <summary>
/// Sampled_ Value. Location. Location_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569265
/// <br/>Indicates where the measured value has been sampled. Default =  "Outlet"
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum LocationEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Body")]
    Body = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Cable")]
    Cable = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"EV")]
    EV = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Inlet")]
    Inlet = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Outlet")]
    Outlet = 4,


}