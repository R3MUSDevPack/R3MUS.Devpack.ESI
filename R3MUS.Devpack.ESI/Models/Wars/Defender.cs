using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace R3MUS.Devpack.ESI.Models.Wars
{
    public class Defender
    {
        [JsonProperty(PropertyName = "ships_killed")]
        public int ShipsKilled { get; set; }

        [JsonProperty(PropertyName = "isk_destroyed")]
        public decimal IskDestroyed { get; set; }

        [OptionalField]
        [JsonProperty(PropertyName = "alliance_id")]
        public long? Alliance_Id;

        [OptionalField]
        [JsonProperty(PropertyName = "corporation_id")]
        public long? Corporation_Id;
    }
}