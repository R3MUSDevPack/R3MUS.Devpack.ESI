using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    /// <summary>
    /// https://esi.tech.ccp.is/latest/universe/structures/1023736622218/?datasource=tranquility
    /// </summary>
    public class Structure
    {
        [JsonIgnore]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "solar_system_id")]
        public int SolarSystemId { get; set; }
        [JsonProperty(PropertyName = "type_id")]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

        public Structure()
        {
        }

        public Structure(long id, string accessToken)
        {
            Id = id;
            this.GetStructure(new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", accessToken))
            });
        }
    }
}
