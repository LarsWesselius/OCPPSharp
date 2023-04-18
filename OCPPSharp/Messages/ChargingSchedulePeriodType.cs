namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Schedule_ Period
/// <br/>urn:x-oca:ocpp:uid:2:233257
/// <br/>Charging schedule period structure defines a time period in a charging schedule.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingSchedulePeriodType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Charging_ Schedule_ Period. Start_ Period. Elapsed_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569240
    /// <br/>Start of the period, in seconds from the start of schedule. The value of StartPeriod also defines the stop time of the previous period.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("startPeriod")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int StartPeriod { get; set; }

    /// <summary>
    /// Charging_ Schedule_ Period. Limit. Measure
    /// <br/>urn:x-oca:ocpp:uid:1:569241
    /// <br/>Charging rate limit during the schedule period, in the applicable chargingRateUnit, for example in Amperes (A) or Watts (W). Accepts at most one digit fraction (e.g. 8.1).
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("limit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public double Limit { get; set; }

    /// <summary>
    /// Charging_ Schedule_ Period. Number_ Phases. Counter
    /// <br/>urn:x-oca:ocpp:uid:1:569242
    /// <br/>The number of phases that can be used for charging. If a number of phases is needed, numberPhases=3 will be assumed unless another number is given.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("numberPhases")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int NumberPhases { get; set; }

    /// <summary>
    /// Values: 1..3, Used if numberPhases=1 and if the EVSE is capable of switching the phase connected to the EV, i.e. ACPhaseSwitchingSupported is defined and true. It’s not allowed unless both conditions above are true. If both conditions are true, and phaseToUse is omitted, the Charging Station / EVSE will make the selection on its own.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("phaseToUse")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int PhaseToUse { get; set; }


}