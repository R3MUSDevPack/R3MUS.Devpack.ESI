using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class CharacterNames
    {

        [JsonProperty(PropertyName = "applicationjson")]
        public Summary[] CharacterDetail { get; set; }
    }
}
