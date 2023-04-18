namespace OCPPSharp.Messages;
/// <summary>
/// APN
/// <br/>urn:x-oca:ocpp:uid:2:233134
/// <br/>Collection of configuration data needed to make a data-connection over a cellular network.
/// <br/>
/// <br/>NOTE: When asking a GSM modem to dial in, it is possible to specify which mobile operator should be used. This can be done with the mobile country code (MCC) in combination with a mobile network code (MNC). Example: If your preferred network is Vodafone Netherlands, the MCC=204 and the MNC=04 which means the key PreferredNetwork = 20404 Some modems allows to specify a preferred network, which means, if this network is not available, a different network is used. If you specify UseOnlyPreferredNetwork and this network is not available, the modem will not dial in.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class APNType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// APN. APN. URI
    /// <br/>urn:x-oca:ocpp:uid:1:568814
    /// <br/>The Access Point Name as an URL.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("apn")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Apn { get; set; }

    /// <summary>
    /// APN. APN. User_ Name
    /// <br/>urn:x-oca:ocpp:uid:1:568818
    /// <br/>APN username.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("apnUserName")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string ApnUserName { get; set; }

    /// <summary>
    /// APN. APN. Password
    /// <br/>urn:x-oca:ocpp:uid:1:568819
    /// <br/>APN Password.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("apnPassword")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string ApnPassword { get; set; }

    /// <summary>
    /// APN. SIMPIN. PIN_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:568821
    /// <br/>SIM card pin code.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("simPin")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int SimPin { get; set; }

    /// <summary>
    /// APN. Preferred_ Network. Mobile_ Network_ ID
    /// <br/>urn:x-oca:ocpp:uid:1:568822
    /// <br/>Preferred network, written as MCC and MNC concatenated. See note.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("preferredNetwork")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(6)]
    public string PreferredNetwork { get; set; }

    /// <summary>
    /// APN. Use_ Only_ Preferred_ Network. Indicator
    /// <br/>urn:x-oca:ocpp:uid:1:568824
    /// <br/>Default: false. Use only the preferred Network, do
    /// <br/>not dial in when not available. See Note.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("useOnlyPreferredNetwork")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public bool UseOnlyPreferredNetwork { get; set; } = false;


    [System.Text.Json.Serialization.JsonPropertyName("apnAuthentication")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public APNAuthenticationEnumType ApnAuthentication { get; set; }


}