using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models
{
    public class SolarSystem
    {
        [JsonProperty(PropertyName = "system_id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

        [JsonProperty(PropertyName = "security_status")]
        public float SecurityStatus { get; set; }

        [JsonProperty(PropertyName = "constellation_id")]
        public long Constellation_Id { get; set; }

        [JsonIgnore]
        public Constellation Constellation { get; set; }

        [JsonProperty(PropertyName = "planets")]
        public Planet[] Planets { get; set; }

        [JsonProperty(PropertyName = "stargates")]
        public object[] Stargates { get; set; }
        
        public SolarSystem()
        {

        }
        public SolarSystem(long id)
        {
            Id = id;
            //this.GetSolarSystem();
            Constellation = new Constellation(Constellation_Id);
        }
    }
    
    public class Planet
    {
        [JsonProperty(PropertyName = "planet_id")]
        public int Planet_Id { get; set; }
        [JsonProperty(PropertyName = "moons")]
        public int[] Moons { get; set; }
    }

}
