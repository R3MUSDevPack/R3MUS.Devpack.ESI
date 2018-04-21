using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class Blueprint
    {
        [JsonProperty(PropertyName = "item_id")]
        public long ItemId { get; set; }
        [JsonProperty(PropertyName = "type_id")]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "location_id")]
        public int LocationId { get; set; }
        [JsonProperty(PropertyName = "location_flag")]
        public string LocationFlag { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
        [JsonProperty(PropertyName = "time_efficiency")]
        public int TimeEfficiency { get; set; }
        [JsonProperty(PropertyName = "material_efficiency")]
        public int MaterialEfficiency { get; set; }
        [JsonProperty(PropertyName = "runs")]
        public int Runs { get; set; }
    }
}
