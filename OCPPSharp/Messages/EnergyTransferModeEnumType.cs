namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Needs. Requested. Energy_ Transfer_ Mode_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569209
/// <br/>Mode of energy transfer requested by the EV.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum EnergyTransferModeEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"DC")]
    DC = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"AC_single_phase")]
    AC_single_phase = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"AC_two_phase")]
    AC_two_phase = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"AC_three_phase")]
    AC_three_phase = 3,


}