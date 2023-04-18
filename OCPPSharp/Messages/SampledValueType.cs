namespace OCPPSharp.Messages;
/// <summary>
/// Sampled_ Value
/// <br/>urn:x-oca:ocpp:uid:2:233266
/// <br/>Single sampled value in MeterValues. Each value can be accompanied by optional fields.
/// <br/>
/// <br/>To save on mobile data usage, default values of all of the optional fields are such that. The value without any additional fields will be interpreted, as a register reading of active import energy in Wh (Watt-hour) units.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class SampledValueType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Sampled_ Value. Value. Measure
    /// <br/>urn:x-oca:ocpp:uid:1:569260
    /// <br/>Indicates the measured value.
    /// <br/>
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("value")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public double Value { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("context")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
    //[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterEx<ReadingContextEnumType>))]
    public ReadingContextEnumType Context { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("measurand")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
    //[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterEx<MeasurandEnumType>))]
    public MeasurandEnumType Measurand { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("phase")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
    //[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterEx<PhaseEnumType>))]
    public PhaseEnumType Phase { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("location")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    //[System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterEx<LocationEnumType>))]
    public LocationEnumType Location { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("signedMeterValue")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public SignedMeterValueType SignedMeterValue { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("unitOfMeasure")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public UnitOfMeasureType UnitOfMeasure { get; set; }


}