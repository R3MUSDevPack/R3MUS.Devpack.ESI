using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class Summary
    {
        [JsonProperty(PropertyName = "character_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "character_name")]
        public string Name { get; set; }
    }

}
