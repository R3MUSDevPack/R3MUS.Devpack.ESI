using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models
{
    public class Region
    {
        [JsonProperty(PropertyName = "region_id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "constellations")]
        public int[] Constellation_Ids { get; set; }

        public Region()
        {
        }

        public Region (long id)
        {
            Id = id;
            //this.GetRegion();
        }
    }
}
