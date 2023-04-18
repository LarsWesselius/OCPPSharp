namespace OCPPSharp.Messages;
/// <summary>
/// Sampled_ Value. Context. Reading_ Context_ Code
/// <br/>urn:x-oca:ocpp:uid:1:569261
/// <br/>Type of detail value: start, end or sample. Default = "Sample.Periodic"
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ReadingContextEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Interruption.Begin")]
    Interruption_Begin = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Interruption.End")]
    Interruption_End = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Other")]
    Other = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Sample.Clock")]
    Sample_Clock = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Sample.Periodic")]
    Sample_Periodic = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"Transaction.Begin")]
    Transaction_Begin = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"Transaction.End")]
    Transaction_End = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"Trigger")]
    Trigger = 7,


}