namespace OCPPSharp.Messages;
/// <summary>
/// Log
/// <br/>urn:x-enexis:ecdm:uid:2:233373
/// <br/>Generic class for the configuration of logging entries.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class LogParametersType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Log. Remote_ Location. URI
    /// <br/>urn:x-enexis:ecdm:uid:1:569484
    /// <br/>The URL of the location at the remote system where the log should be stored.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("remoteLocation")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(512)]
    public string RemoteLocation { get; set; }

    /// <summary>
    /// Log. Oldest_ Timestamp. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569477
    /// <br/>This contains the date and time of the oldest logging information to include in the diagnostics.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("oldestTimestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset OldestTimestamp { get; set; }

    /// <summary>
    /// Log. Latest_ Timestamp. Date_ Time
    /// <br/>urn:x-enexis:ecdm:uid:1:569482
    /// <br/>This contains the date and time of the latest logging information to include in the diagnostics.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("latestTimestamp")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public System.DateTimeOffset LatestTimestamp { get; set; }


}