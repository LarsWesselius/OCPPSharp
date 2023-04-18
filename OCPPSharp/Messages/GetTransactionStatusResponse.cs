namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class GetTransactionStatusResponse
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Whether the transaction is still ongoing.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("ongoingIndicator")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool OngoingIndicator { get; set; }

    /// <summary>
    /// Whether there are still message to be delivered.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("messagesInQueue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public bool MessagesInQueue { get; set; }


}