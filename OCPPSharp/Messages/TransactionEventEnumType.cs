namespace OCPPSharp.Messages;
/// <summary>
/// This contains the type of this event.
/// <br/>The first TransactionEvent of a transaction SHALL contain: "Started" The last TransactionEvent of a transaction SHALL contain: "Ended" All others SHALL contain: "Updated"
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum TransactionEventEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Ended")]
    Ended = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Started")]
    Started = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Updated")]
    Updated = 2,


}