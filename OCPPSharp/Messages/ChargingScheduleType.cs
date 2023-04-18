namespace OCPPSharp.Messages;
/// <summary>
/// Charging_ Schedule
/// <br/>urn:x-oca:ocpp:uid:2:233256
/// <br/>Charging schedule structure defines a list of charging periods, as used in: GetCompositeSchedule.conf and ChargingProfile. 
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class ChargingScheduleType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identifies the ChargingSchedule.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Id { get; set; }

    /// <summary>
    /// Charging_ Schedule. Start_ Schedule. Date_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569237
    /// <br/>Starting point of an absolute schedule. If absent the schedule will be relative to start of charging.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("startSchedule")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset StartSchedule { get; set; }

    /// <summary>
    /// Charging_ Schedule. Duration. Elapsed_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569236
    /// <br/>Duration of the charging schedule in seconds. If the duration is left empty, the last period will continue indefinitely or until end of the transaction if chargingProfilePurpose = TxProfile.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("duration")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Duration { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingRateUnit")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public ChargingRateUnitEnumType ChargingRateUnit { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("chargingSchedulePeriod")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(1024)]
    public System.Collections.Generic.ICollection<ChargingSchedulePeriodType> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriodType>();

    /// <summary>
    /// Charging_ Schedule. Min_ Charging_ Rate. Numeric
    /// <br/>urn:x-oca:ocpp:uid:1:569239
    /// <br/>Minimum charging rate supported by the EV. The unit of measure is defined by the chargingRateUnit. This parameter is intended to be used by a local smart charging algorithm to optimize the power allocation for in the case a charging process is inefficient at lower charging rates. Accepts at most one digit fraction (e.g. 8.1)
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("minChargingRate")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public double MinChargingRate { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("salesTariff")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public SalesTariffType SalesTariff { get; set; }


}