namespace OCPPSharp.Messages;
/// <summary>
/// Charge_ Point
/// <br/>urn:x-oca:ocpp:uid:2:233122
/// <br/>The physical system where an Electrical Vehicle (EV) can be charged.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingStationType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Device. Serial_ Number. Serial_ Number
    /// <br/>urn:x-oca:ocpp:uid:1:569324
    /// <br/>Vendor-specific device identifier.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("serialNumber")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(25)]
    public string SerialNumber { get; set; }

    /// <summary>
    /// Device. Model. CI20_ Text
    /// <br/>urn:x-oca:ocpp:uid:1:569325
    /// <br/>Defines the model of the device.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("model")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string Model { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("modem")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public ModemType Modem { get; set; }

    /// <summary>
    /// Identifies the vendor (not necessarily in a unique manner).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("vendorName")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string VendorName { get; set; }

    /// <summary>
    /// This contains the firmware version of the Charging Station.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("firmwareVersion")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string FirmwareVersion { get; set; }


}