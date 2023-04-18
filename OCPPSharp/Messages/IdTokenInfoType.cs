namespace OCPPSharp.Messages;
/// <summary>
/// ID_ Token
/// <br/>urn:x-oca:ocpp:uid:2:233247
/// <br/>Contains status information about an identifier.
/// <br/>It is advised to not stop charging for a token that expires during charging, as ExpiryDate is only used for caching purposes. If ExpiryDate is not given, the status has no end date.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class IdTokenInfoType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("status")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public AuthorizationStatusEnumType Status { get; set; }

    /// <summary>
    /// ID_ Token. Expiry. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569373
    /// <br/>Date and Time after which the token must be considered invalid.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("cacheExpiryDateTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset CacheExpiryDateTime { get; set; }

    /// <summary>
    /// Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; overrules this one. 
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("chargingPriority")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int ChargingPriority { get; set; }

    /// <summary>
    /// ID_ Token. Language1. Language_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569374
    /// <br/>Preferred user interface language of identifier user. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("language1")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(8)]
    public string Language1 { get; set; }

    /// <summary>
    /// Only used when the IdToken is only valid for one or more specific EVSEs, not for the entire Charging Station.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<int> EvseId { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("groupIdToken")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public IdTokenType GroupIdToken { get; set; }

    /// <summary>
    /// ID_ Token. Language2. Language_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569375
    /// <br/>Second preferred user interface language of identifier user. Don’t use when language1 is omitted, has to be different from language1. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("language2")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(8)]
    public string Language2 { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("personalMessage")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public MessageContentType PersonalMessage { get; set; }


}