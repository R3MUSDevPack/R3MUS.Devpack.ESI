using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    public class Region
    {
        [JsonProperty(PropertyName = "region_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "constellations")]
        public List<long> Constellations { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        public Region()
        {}

        public Region(long id)
        {
            Id = id;
            this.GetRegion();
        }
    }
}
