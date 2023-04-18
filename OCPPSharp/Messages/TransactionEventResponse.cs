namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class TransactionEventResponse
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// SHALL only be sent when charging has ended. Final total cost of this transaction, including taxes. In the currency configured with the Configuration Variable: &amp;lt;&amp;lt;configkey-currency,`Currency`&amp;gt;&amp;gt;. When omitted, the transaction was NOT free. To indicate a free transaction, the CSMS SHALL send 0.00.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("totalCost")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public double TotalCost { get; set; }

    /// <summary>
    /// Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; is temporarily, so it may not be set in the &amp;lt;&amp;lt;cmn_idtokeninfotype,IdTokenInfoType&amp;gt;&amp;gt; afterwards. Also the chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; overrules the one in &amp;lt;&amp;lt;cmn_idtokeninfotype,IdTokenInfoType&amp;gt;&amp;gt;.  
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("chargingPriority")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int ChargingPriority { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("idTokenInfo")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public IdTokenInfoType IdTokenInfo { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("updatedPersonalMessage")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public MessageContentType UpdatedPersonalMessage { get; set; }


}