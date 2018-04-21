using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Corporation
{
    public class Detail
    {
        public long Id { get; set; }

        [JsonProperty(PropertyName = "alliance_id")]
        public long? AllianceId { get; set; }

        [JsonProperty(PropertyName = "ceo_id")]
        public long CEOId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "date_founded")]
        public DateTime CreationDate { get; set; }

        [JsonProperty(PropertyName = "creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty(PropertyName = "faction_id")]
        public long? FactionId { get; set; }

        [JsonProperty(PropertyName = "member_count")]
        public long MemberCount { get; set; }

        [JsonProperty(PropertyName = "tax_rate")]
        public float TaxRate { get; set; }

        [JsonProperty(PropertyName = "ticker")]
        public string Ticker { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        public Detail()
        {

        }
        public Detail(long id)
        {
            Id = id;
            this.GetCorporation();
            Id = id;
        }
    }

    public class Corporations
    {
        public List<long> CorpIds { get; set; }
    }
}
