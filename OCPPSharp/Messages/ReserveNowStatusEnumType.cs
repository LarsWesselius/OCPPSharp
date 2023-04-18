namespace OCPPSharp.Messages;
/// <summary>
/// This indicates the success or failure of the reservation.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum ReserveNowStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"Faulted")]
    Faulted = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"Occupied")]
    Occupied = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
    Rejected = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"Unavailable")]
    Unavailable = 4,


}