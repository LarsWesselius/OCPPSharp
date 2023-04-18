namespace OCPPSharp.Messages;
/// <summary>
/// DC_ Charging_ Parameters
/// <br/>urn:x-oca:ocpp:uid:2:233251
/// <br/>EV DC charging parameters
/// <br/>
/// <br/>
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class DCChargingParametersType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. EV_ Max. Current
    /// <br/>urn:x-oca:ocpp:uid:1:569215
    /// <br/>Maximum current (amps) supported by the electric vehicle. Includes cable capacity.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMaxCurrent")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvMaxCurrent { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. EV_ Max. Voltage
    /// <br/>urn:x-oca:ocpp:uid:1:569216
    /// <br/>Maximum voltage supported by the electric vehicle
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMaxVoltage")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvMaxVoltage { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. Energy_ Amount. Energy_ Amount
    /// <br/>urn:x-oca:ocpp:uid:1:569217
    /// <br/>Amount of energy requested (in Wh). This inludes energy required for preconditioning.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("energyAmount")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int EnergyAmount { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. EV_ Max. Power
    /// <br/>urn:x-oca:ocpp:uid:1:569218
    /// <br/>Maximum power (in W) supported by the electric vehicle. Required for DC charging.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evMaxPower")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int EvMaxPower { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. State_ Of_ Charge. Numeric
    /// <br/>urn:x-oca:ocpp:uid:1:569219
    /// <br/>Energy available in the battery (in percent of the battery capacity)
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("stateOfCharge")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.Range(0, 100)]
    public int StateOfCharge { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. EV_ Energy_ Capacity. Numeric
    /// <br/>urn:x-oca:ocpp:uid:1:569220
    /// <br/>Capacity of the electric vehicle battery (in Wh)
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evEnergyCapacity")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int EvEnergyCapacity { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. Full_ SOC. Percentage
    /// <br/>urn:x-oca:ocpp:uid:1:569221
    /// <br/>Percentage of SoC at which the EV considers the battery fully charged. (possible values: 0 - 100)
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("fullSoC")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.Range(0, 100)]
    public int FullSoC { get; set; }

    /// <summary>
    /// DC_ Charging_ Parameters. Bulk_ SOC. Percentage
    /// <br/>urn:x-oca:ocpp:uid:1:569222
    /// <br/>Percentage of SoC at which the EV considers a fast charging process to end. (possible values: 0 - 100)
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("bulkSoC")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.Range(0, 100)]
    public int BulkSoC { get; set; }


}