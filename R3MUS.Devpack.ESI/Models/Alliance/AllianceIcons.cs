using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Models.Shared;

namespace R3MUS.Devpack.ESI.Models.Alliance
{
    public partial class AllianceIcons
    {
        [JsonProperty(PropertyName = "applicationjson")]
        public Icons Icons { get; set; }
    }

}
