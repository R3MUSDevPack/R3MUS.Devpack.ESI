using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    public class SolarSystem
    {
        [JsonProperty(PropertyName = "system_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "star_id")]
        public int StarId { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
        [JsonProperty(PropertyName = "security_status")]
        public decimal SecurityStatus { get; set; }
        [JsonProperty(PropertyName = "constellation_id")]
        public int ConstellationId { get; set; }
        [JsonProperty(PropertyName = "planets")]
        public List<Planet> Planets { get; set; }
        [JsonProperty(PropertyName = "security_class")]
        public string SecurityClass { get; set; }
        [JsonProperty(PropertyName = "stargates")]
        public List<int> Stargates { get; set; }

        public SolarSystem()
        {}

        public SolarSystem(long id)
        {
            Id = id;
            this.GetSolarSystem();
        }
    }
}