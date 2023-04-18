namespace OCPPSharp.Messages;
/// <summary>
/// Cost. Cost_ Kind. Cost_ Kind_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569243
/// <br/>The kind of cost referred to in the message element amount
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum CostKindEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"CarbonDioxideEmission")]
    CarbonDioxideEmission = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"RelativePricePercentage")]
    RelativePricePercentage = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"RenewableGenerationPercentage")]
    RenewableGenerationPercentage = 2,


}