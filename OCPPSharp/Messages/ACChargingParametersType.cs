namespace OCPPSharp.Messages;
/// <summary>
/// AC_ Charging_ Parameters
/// <br/>urn:x-oca:ocpp:uid:2:233250
/// <br/>EV AC charging parameters.
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ACChargingParametersType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// AC_ Charging_ Parameters. Energy_ Amount. Energy_ Amount
    /// <br/>urn:x-oca:ocpp:uid:1:569211
    /// <br/>Amount of energy requested (in Wh). This includes energy required for preconditioning.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("energyAmount")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EnergyAmount { get; set; }

    /// <summary>
    /// AC_ Charging_ Parameters. EV_ Min. Current
    /// <br/>urn:x-oca:ocpp:uid:1:569212
    /// <br/>Minimum current (amps) supported by the electric vehicle (per phase).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMinCurrent")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvMinCurrent { get; set; }

    /// <summary>
    /// AC_ Charging_ Parameters. EV_ Max. Current
    /// <br/>urn:x-oca:ocpp:uid:1:569213
    /// <br/>Maximum current (amps) supported by the electric vehicle (per phase). Includes cable capacity.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMaxCurrent")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvMaxCurrent { get; set; }

    /// <summary>
    /// AC_ Charging_ Parameters. EV_ Max. Voltage
    /// <br/>urn:x-oca:ocpp:uid:1:569214
    /// <br/>Maximum voltage supported by the electric vehicle
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMaxVoltage")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvMaxVoltage { get; set; }


}