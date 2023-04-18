namespace OCPPSharp.Messages;
/// <summary>
/// Composite_ Schedule
/// <br/>urn:x-oca:ocpp:uid:2:233362
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class CompositeScheduleType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingSchedulePeriod")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<ChargingSchedulePeriodType> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriodType>();

    /// <summary>
    /// The ID of the EVSE for which the
    /// <br/>schedule is requested. When evseid=0, the
    /// <br/>Charging Station calculated the expected
    /// <br/>consumption for the grid connection.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("evseId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int EvseId { get; set; }

    /// <summary>
    /// Duration of the schedule in seconds.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("duration")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Duration { get; set; }

    /// <summary>
    /// Composite_ Schedule. Start. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569456
    /// <br/>Date and time at which the schedule becomes active. All time measurements within the schedule are relative to this timestamp.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("scheduleStart")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public System.DateTimeOffset ScheduleStart { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingRateUnit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingRateUnitEnumType ChargingRateUnit { get; set; }


}