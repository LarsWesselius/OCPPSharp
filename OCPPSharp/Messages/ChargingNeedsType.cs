namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Needs
/// <br/>urn:x-oca:ocpp:uid:2:233249
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingNeedsType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("acChargingParameters")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public ACChargingParametersType AcChargingParameters { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("dcChargingParameters")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public DCChargingParametersType DcChargingParameters { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("requestedEnergyTransfer")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public EnergyTransferModeEnumType RequestedEnergyTransfer { get; set; }

    /// <summary>
    /// Charging_ Needs. Departure_ Time. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569223
    /// <br/>Estimated departure time of the EV.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("departureTime")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset DepartureTime { get; set; }


}