namespace OCPPSharp.Messages;
/// <summary>
/// Attribute type for which value is requested. When absent, default Actual is assumed.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum AttributeEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Actual")]
    Actual = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Target")]
    Target = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"MinSet")]
    MinSet = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"MaxSet")]
    MaxSet = 3,


}