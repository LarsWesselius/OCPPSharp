namespace OCPPSharp.Messages;
/// <summary>
/// Wireless_ Communication_ Module
/// <br/>urn:x-oca:ocpp:uid:2:233306
/// <br/>Defines parameters required for initiating and maintaining wireless communication with other devices.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ModemType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Wireless_ Communication_ Module. ICCID. CI20_ Text
    /// <br/>urn:x-oca:ocpp:uid:1:569327
    /// <br/>This contains the ICCID of the modem’s SIM card.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("iccid")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Iccid { get; set; }

    /// <summary>
    /// Wireless_ Communication_ Module. IMSI. CI20_ Text
    /// <br/>urn:x-oca:ocpp:uid:1:569328
    /// <br/>This contains the IMSI of the modem’s SIM card.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("imsi")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Imsi { get; set; }


}