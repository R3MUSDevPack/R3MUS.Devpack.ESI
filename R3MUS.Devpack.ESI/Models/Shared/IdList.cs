using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
