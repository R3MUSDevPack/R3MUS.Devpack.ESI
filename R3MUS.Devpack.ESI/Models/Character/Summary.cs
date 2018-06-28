using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class Summary
    {
        [JsonProperty(PropertyName = "character_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "character_name")]
        public string Name { get; set; }
        public long? CorporationId { get; set; }
    }
}
