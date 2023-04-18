namespace OCPPSharp.Messages;
/// <summary>
/// Transaction
/// <br/>urn:x-oca:ocpp:uid:2:233318
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class TransactionType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// This contains the Id of the transaction.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("transactionId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(36)]
    public string TransactionId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingState")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingStateEnumType ChargingState { get; set; }

    /// <summary>
    /// Transaction. Time_ Spent_ Charging. Elapsed_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569415
    /// <br/>Contains the total time that energy flowed from EVSE to EV during the transaction (in seconds). Note that timeSpentCharging is smaller or equal to the duration of the transaction.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("timeSpentCharging")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int TimeSpentCharging { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("stoppedReason")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ReasonEnumType StoppedReason { get; set; }

    /// <summary>
    /// The ID given to remote start request (&amp;lt;&amp;lt;requeststarttransactionrequest, RequestStartTransactionRequest&amp;gt;&amp;gt;. This enables to CSMS to match the started transaction to the given start request.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("remoteStartId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int RemoteStartId { get; set; }


}