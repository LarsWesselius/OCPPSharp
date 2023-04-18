namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class PublishFirmwareRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// This contains a string containing a URI pointing to a
    /// <br/>location from which to retrieve the firmware.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("location")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Location { get; set; }

    /// <summary>
    /// This specifies how many times Charging Station must try
    /// <br/>to download the firmware before giving up. If this field is not
    /// <br/>present, it is left to Charging Station to decide how many times it wants to retry.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("retries")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Retries { get; set; }

    /// <summary>
    /// The MD5 checksum over the entire firmware file as a hexadecimal string of length 32. 
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("checksum")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(32)]
    public string Checksum { get; set; }

    /// <summary>
    /// The Id of the request.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }

    /// <summary>
    /// The interval in seconds
    /// <br/>after which a retry may be
    /// <br/>attempted. If this field is not
    /// <br/>present, it is left to Charging
    /// <br/>Station to decide how long to wait
    /// <br/>between attempts.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("retryInterval")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int RetryInterval { get; set; }


}