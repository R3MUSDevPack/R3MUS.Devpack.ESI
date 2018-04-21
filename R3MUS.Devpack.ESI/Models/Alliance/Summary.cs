using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Alliance
{
    public partial class Summary
    {
        [JsonProperty(PropertyName = "alliance_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "alliance_name")]
        public string Name { get; set; }
    }
}
