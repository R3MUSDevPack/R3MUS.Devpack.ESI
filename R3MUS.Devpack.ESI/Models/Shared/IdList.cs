using Newtonsoft.Json;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class IdList
    {
        public List<long> Ids { get; set; }
    }

    public class CharacterSearchResponse
    {
        [JsonProperty(PropertyName = "character")]
        public List<int> Characters { get; set; }
    }
}
