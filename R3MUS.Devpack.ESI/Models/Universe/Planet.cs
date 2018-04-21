using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    public class Planet
    {
        [JsonProperty(PropertyName = "planet_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "moons")]
        public List<long> Moons { get; set; }
    }
}
