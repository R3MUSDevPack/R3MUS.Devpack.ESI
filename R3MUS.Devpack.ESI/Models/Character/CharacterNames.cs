using Newtonsoft.Json;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class CharacterNames
    {

        [JsonProperty(PropertyName = "applicationjson")]
        public List<Summary> CharacterDetail { get; set; }
    }
}
