namespace OCPPSharp.Messages;
/// <summary>
/// EVSE
/// <br/>urn:x-oca:ocpp:uid:2:233123
/// <br/>Electric Vehicle Supply Equipment
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class EVSEType
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }

    /// <summary>
    /// Identified_ Object. MRID. Numeric_ Identifier
    /// <br/>urn:x-enexis:ecdm:uid:1:569198
    /// <br/>EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("id")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int Id { get; set; }

    /// <summary>
    /// An id to designate a specific connector (on an EVSE) by connector index number.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("connectorId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public int ConnectorId { get; set; }


}