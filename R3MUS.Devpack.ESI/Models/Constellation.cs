using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models
{
    public class Constellation
    {
        [JsonProperty(PropertyName = = "constellation_id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

        [JsonProperty(PropertyName = "region_id")]
        public int Region_Id { get; set; }

        [JsonProperty(PropertyName = "systems")]
        public int[] Systems { get; set; }

        [JsonIgnore]
        public Region Region { get; set; }

        public Constellation()
        {
        }

        public Constellation(long id)
        {
            Id = id;
            this.GetConstellation();
            Region = new Region(Region_Id);
        }
    }

    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

}
