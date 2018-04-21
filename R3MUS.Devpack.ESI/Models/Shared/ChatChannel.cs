using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class ChatChannel
    {
        [JsonProperty(PropertyName = "channel_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty(PropertyName = "comparison_key")]
        public string ComparisonKey { get; set; }
        [JsonProperty(PropertyName = "has_password")]
        public bool HasPassword { get; set; }
        [JsonProperty(PropertyName = "motd")]
        public string MessageOfTheDay { get; set; }
        [JsonProperty(PropertyName = "allowed")]
        public Entity[] AllowList { get; set; }
        [JsonProperty(PropertyName = "operators")]
        public Entity[] OperatorList { get; set; }
        [JsonProperty(PropertyName = "blocked")]
        public Entity[] BlockList { get; set; }
        [JsonProperty(PropertyName = "muted")]
        public Entity[] MuteList { get; set; }


        public class Entity
        {
            [JsonProperty(PropertyName = "accessor_id")]
            public int Id { get; set; }
            [JsonProperty(PropertyName = "accessor_type")]
            public string Type { get; set; }
        }
    }    
}
