namespace OCPPSharp.Messages;
/// <summary>
/// Relative_ Timer_ Interval
/// <br/>urn:x-oca:ocpp:uid:2:233270
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class RelativeTimeIntervalType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Relative_ Timer_ Interval. Start. Elapsed_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569279
    /// <br/>Start of the interval, in seconds from NOW.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("start")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Start { get; set; }

    /// <summary>
    /// Relative_ Timer_ Interval. Duration. Elapsed_ Time
    /// <br/>urn:x-oca:ocpp:uid:1:569280
    /// <br/>Duration of the interval, in seconds.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("duration")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int Duration { get; set; }


}