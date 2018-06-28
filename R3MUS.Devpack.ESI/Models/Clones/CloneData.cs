using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Clones
{
    public class CloneData
    {
        [JsonProperty(PropertyName = "home_location")]
        public Location HomeStation { get; set; }
        [JsonProperty(PropertyName = "jump_clones")]
        public List<JumpClone> JumpClones { get; set; }
        [JsonProperty(PropertyName = "last_clone_jump_date")]
        public DateTime LastCloneJumpTimestamp { get; set; }
        [JsonProperty(PropertyName = "last_station_change_date")]
        public DateTime LastHomeStationChangeTimestamp { get; set; }
    }
    
    public class Location
    {
        [JsonProperty(PropertyName = "location_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public string Type { get; set; }
    }

    public class JumpClone
    {
        [JsonProperty(PropertyName = "implants")]
        public List<int?> Implants { get; set; }
        [JsonProperty(PropertyName = "jump_clone_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "location_id")]
        public long LocationId { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

}
