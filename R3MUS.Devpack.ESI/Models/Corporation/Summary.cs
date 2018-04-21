using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Corporation
{
    public class Summary
    {
        [JsonProperty(PropertyName = "corporation_id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "corporation_name")]
        public string Name { get; set; }
    }
}
