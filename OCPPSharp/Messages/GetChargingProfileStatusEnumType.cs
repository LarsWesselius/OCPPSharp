namespace OCPPSharp.Messages;
/// <summary>
/// This indicates whether the Charging Station is able to process this request and will send &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; messages.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
public enum GetChargingProfileStatusEnumType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
    Accepted = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"NoProfiles")]
    NoProfiles = 1,


}