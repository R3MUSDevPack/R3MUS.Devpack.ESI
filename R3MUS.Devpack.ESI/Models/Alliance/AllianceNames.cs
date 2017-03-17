using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Alliance
{
    public partial class AllianceNames
    {
        [JsonProperty(PropertyName = "applicationjson")]
        public Summary[] AllianceDetail { get; set; }
    }

}
