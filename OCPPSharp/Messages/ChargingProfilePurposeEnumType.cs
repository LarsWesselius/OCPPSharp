namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569231
/// <br/>Specifies to purpose of the charging profiles that will be cleared, if they meet the other criteria in the request.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ChargingProfilePurposeEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"ChargingStationExternalConstraints")]
    ChargingStationExternalConstraints = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"ChargingStationMaxProfile")]
    ChargingStationMaxProfile = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"TxDefaultProfile")]
    TxDefaultProfile = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"TxProfile")]
    TxProfile = 3,


}