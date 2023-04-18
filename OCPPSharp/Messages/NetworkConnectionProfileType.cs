namespace OCPPSharp.Messages;
/// <summary>
/// Communication_ Function
/// <br/>urn:x-oca:ocpp:uid:2:233304
/// <br/>The NetworkConnectionProfile defines the functional and technical parameters of a communication link.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class NetworkConnectionProfileType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("apn")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public APNType Apn { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("ocppVersion")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public OCPPVersionEnumType OcppVersion { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("ocppTransport")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public OCPPTransportEnumType OcppTransport { get; set; }

    /// <summary>
    /// Communication_ Function. OCPP_ Central_ System_ URL. URI
    /// <br/>urn:x-oca:ocpp:uid:1:569357
    /// <br/>URL of the CSMS(s) that this Charging Station  communicates with.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("ocppCsmsUrl")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string OcppCsmsUrl { get; set; }

    /// <summary>
    /// Duration in seconds before a message send by the Charging Station via this network connection times-out.
    /// <br/>The best setting depends on the underlying network and response times of the CSMS.
    /// <br/>If you are looking for a some guideline: use 30 seconds as a starting point.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("messageTimeout")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int MessageTimeout { get; set; }

    /// <summary>
    /// This field specifies the security profile used when connecting to the CSMS with this NetworkConnectionProfile.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("securityProfile")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int SecurityProfile { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("ocppInterface")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public OCPPInterfaceEnumType OcppInterface { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("vpn")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public VPNType Vpn { get; set; }


}