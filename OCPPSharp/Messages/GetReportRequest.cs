namespace OCPPSharp.Messages;
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public partial class GetReportRequest
{

    [System.Text.Json.Serialization.JsonPropertyName("customData")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    public CustomDataType CustomData { get; set; }


    [System.Text.Json.Serialization.JsonPropertyName("componentVariable")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public System.Collections.Generic.ICollection<ComponentVariableType> ComponentVariable { get; set; }

    /// <summary>
    /// The Id of the request.
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("requestId")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
    public int RequestId { get; set; }

    /// <summary>
    /// This field contains criteria for components for which a report is requested
    /// <br/>
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("componentCriteria")]

    [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   

    // TODO(system.text.json): Add string enum item converter
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    [System.ComponentModel.DataAnnotations.MaxLength(4)]
    public System.Collections.Generic.ICollection<ComponentCriterionEnumType> ComponentCriteria { get; set; }


}