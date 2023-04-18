namespace OCPPSharp.Messages;
/// <summary>
/// Firmware
/// <br/>urn:x-enexis:ecdm:uid:2:233291
/// <br/>Represents a copy of the firmware that can be loaded/updated on the Charging Station.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class FirmwareType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Firmware. Location. URI
    /// <br/>urn:x-enexis:ecdm:uid:1:569460
    /// <br/>URI defining the origin of the firmware.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("location")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string Location { get; set; }

    /// <summary>
    /// Firmware. Retrieve. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569461
    /// <br/>Date and time at which the firmware shall be retrieved.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("retrieveDateTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset RetrieveDateTime { get; set; }

    /// <summary>
    /// Firmware. Install. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569462
    /// <br/>Date and time at which the firmware shall be installed.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("installDateTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset InstallDateTime { get; set; }

    /// <summary>
    /// Certificate with which the firmware was signed.
    /// <br/>PEM encoded X.509 certificate.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("signingCertificate")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(5500)]
    public string SigningCertificate { get; set; }

    /// <summary>
    /// Firmware. Signature. Signature
    /// <br/>urn:x-enexis:ecdm:uid:1:569464
    /// <br/>Base64 encoded firmware signature.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("signature")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(800)]
    public string Signature { get; set; }


}