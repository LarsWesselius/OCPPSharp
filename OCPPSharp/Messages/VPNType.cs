namespace OCPPSharp.Messages;
/// <summary>
/// VPN
/// <br/>urn:x-oca:ocpp:uid:2:233268
/// <br/>VPN Configuration settings
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class VPNType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// VPN. Server. URI
    /// <br/>urn:x-oca:ocpp:uid:1:569272
    /// <br/>VPN Server Address
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("server")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Server { get; set; }

    /// <summary>
    /// VPN. User. User_ Name
    /// <br/>urn:x-oca:ocpp:uid:1:569273
    /// <br/>VPN User
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("user")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string User { get; set; }

    /// <summary>
    /// VPN. Group. Group_ Name
    /// <br/>urn:x-oca:ocpp:uid:1:569274
    /// <br/>VPN group.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("group")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Group { get; set; }

    /// <summary>
    /// VPN. Password. Password
    /// <br/>urn:x-oca:ocpp:uid:1:569275
    /// <br/>VPN Password.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("password")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Password { get; set; }

    /// <summary>
    /// VPN. Key. VPN_ Key
    /// <br/>urn:x-oca:ocpp:uid:1:569276
    /// <br/>VPN shared secret.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("key")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(255)]
    public string Key { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("type")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public VPNEnumType Type { get; set; }


}