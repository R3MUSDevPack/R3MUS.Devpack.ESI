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
        public long? Alliance_Id { get; set; }

        [JsonProperty(PropertyName = "ceo_id")]
        public long CEO_Id { get; set; }

        [JsonProperty(PropertyName = "corporation_description")]
        public string Corporation_Description { get; set; }

        [JsonProperty(PropertyName = "corporation_name")]
        public string Corporation_Name { get; set; }

        [JsonProperty(PropertyName = "creation_date")]
        public DateTime Creation_Date { get; set; }

        [JsonProperty(PropertyName = "creator_id")]
        public long Creator_Id { get; set; }

        [JsonProperty(PropertyName = "member_count")]
        public long Member_Count { get; set; }

        [JsonProperty(PropertyName = "tax_rate")]
        public float Tax_Rate { get; set; }

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
        }
    }

    public class Corporations
    {
        public List<long> CorpIds { get; set; }
    }
}
