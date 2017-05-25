using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace R3MUS.Devpack.ESI.Models
{
    public class War
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "declared")]
        public DateTime Declared { get; set; }

        [JsonProperty(PropertyName = "mutual")]
        public bool Mutual { get; set; }

        [JsonProperty(PropertyName = "open_for_allies")]
        public bool OpenForAllies { get; set; }

        [JsonProperty(PropertyName = "aggressor")]
        public Aggressor Aggressor { get; set; }

        [JsonProperty(PropertyName = "defender")]
        public Defender Defender { get; set; }

        [JsonProperty(PropertyName = "started")]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "finished")]
        public DateTime? EndTime { get; set; }

        public War()
        {
        
        }
        public War(long id)
        {
            Id = id;
            this.GetWar();
        }
        
        public static List<long> GetWarIds(long? lastWarId = null)
        {
            return WarExt.GetWars().WarIds.Where(warId => (lastWarId == null) || (warId > lastWarId)).ToList();
        }
    }

    public class Aggressor
    {
        [JsonProperty(PropertyName = "ships_killed")]
        public int ShipsKilled { get; set; }

        [JsonProperty(PropertyName = "isk_destroyed")]
        public float IskDestroyed { get; set; }

        [OptionalField]
        [JsonProperty(PropertyName = "alliance_id")]
        public long? Alliance_Id;

        [OptionalField]
        [JsonProperty(PropertyName = "corporation_id")]
        public long? Corporation_Id;
    }

    public class Defender
    {
        [JsonProperty(PropertyName = "ships_killed")]
        public int ShipsKilled { get; set; }

        [JsonProperty(PropertyName = "isk_destroyed")]
        public float IskDestroyed { get; set; }

        [OptionalField]
        [JsonProperty(PropertyName = "alliance_id")]
        public long? Alliance_Id;

        [OptionalField]
        [JsonProperty(PropertyName = "corporation_id")]
        public long? Corporation_Id;
    }

    public class Wars
    {
        public List<long> WarIds { get; set; }        
    }
}
