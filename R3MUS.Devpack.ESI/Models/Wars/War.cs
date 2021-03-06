﻿using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Wars
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
            return WarExt.GetWars().Ids.Where(warId => (lastWarId == null) || (warId > lastWarId)).ToList();
        }
    }
}
