using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    public class Constellation
    {
        [JsonProperty (PropertyName = "constellation_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
        [JsonProperty(PropertyName = "region_id")]
        public long RegionId { get; set; }
        [JsonProperty(PropertyName = "systems")]
        public List<long> Systems { get; set; }

        public Constellation()
        {}

        public Constellation(long id)
        {
            Id = id;
            this.GetConstellation();
        }
    }
}
