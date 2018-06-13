using Newtonsoft.Json;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class SearchResponse
    {
        [JsonProperty(PropertyName = "corporation")]
        public List<long> Corporations { get; set; }
    }
}
