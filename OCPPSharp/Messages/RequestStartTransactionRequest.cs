namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class RequestStartTransactionRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Number of the EVSE on which to start the transaction. EvseId SHALL be &amp;gt; 0
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int EvseId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("groupIdToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public IdTokenType GroupIdToken { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("idToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    public IdTokenType IdToken { get; set; } = new IdTokenType();

    /// <summary>
    /// Id given by the server to this start request. The Charging Station might return this in the &amp;lt;&amp;lt;transactioneventrequest, TransactionEventRequest&amp;gt;&amp;gt;, letting the server know which transaction was started for this request. Use to start a transaction.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("remoteStartId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RemoteStartId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingProfile")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public ChargingProfileType ChargingProfile { get; set; }


}