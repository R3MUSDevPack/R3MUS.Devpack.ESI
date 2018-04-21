using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Killmails
{
    public class Killmail
    {
        [JsonProperty(PropertyName = "killmail_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "killmail_time")]
        public DateTime Time { get; set; }
        [JsonProperty(PropertyName = "victim")]
        public Victim Victim { get; set; }
        [JsonProperty(PropertyName = "attackers")]
        public List<Attacker> Attackers { get; set; }
        [JsonProperty(PropertyName = "solar_system_id")]
        public int SolarSystemId { get; set; }
    }

    public class Victim
    {
        public int damage_taken { get; set; }
        [JsonProperty(PropertyName = "ship_type_id")]
        public int ShipTypeId { get; set; }
        [JsonProperty(PropertyName = "character_id")]
        public int CharacterId { get; set; }
        [JsonProperty(PropertyName = "corporation_id")]
        public int Corporation { get; set; }
        [JsonProperty(PropertyName = "alliance_id")]
        public int AllianceId { get; set; }
        public Item[] items { get; set; }
        public Position position { get; set; }
    }

    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Item
    {
        public int item_type_id { get; set; }
        public int singleton { get; set; }
        public int flag { get; set; }
        public int quantity_dropped { get; set; }
        public int quantity_destroyed { get; set; }
    }

    public class Attacker
    {
        public float security_status { get; set; }
        public bool final_blow { get; set; }
        public int damage_done { get; set; }
        [JsonProperty(PropertyName = "ship_type_id")]
        public int ShipTypeId { get; set; }
        [JsonProperty(PropertyName = "character_id")]
        public int CharacterId { get; set; }
        [JsonProperty(PropertyName = "corporation_id")]
        public int Corporation { get; set; }
        [JsonProperty(PropertyName = "alliance_id")]
        public int AllianceId { get; set; }
        public int weapon_type_id { get; set; }
    }

}
