using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models
{
    public class Alliance
    {
        private List<long> _corporationIds;
        private List<Corporation> _corps = new List<Corporation>();

        public long Id { get; set; }

        [JsonProperty(PropertyName = "alliance_name")]
        public string Alliance_Name { get; set; }

        [JsonProperty(PropertyName = "ticker")]
        public string Ticker { get; set; }

        [JsonProperty(PropertyName = "date_founded")]
        public DateTime Date_Founded { get; set; }

        [JsonProperty(PropertyName = "executor_corp")]
        public int Executor_Corp { get; set; }

        [IgnoreDataMember]
        public virtual List<long> CorporationIds
        {
            get
            {
                if (_corporationIds == null) { _corporationIds = this.GetCorporationIds().CorpIds; }
                return _corporationIds;
            }
        }

        public Alliance()
        {

        }
        public Alliance(long id)
        {
            Id = id;
            this.GetAlliance();
        }
    }

    public class Alliances
    {
        public List<long> AllianceIds { get; set; }
    }

    public class AllianceNames
    {
        [JsonProperty(PropertyName = "applicationjson")]
        public AllianceDetail[] AllianceDetail { get; set; }
    }

    public class AllianceDetail
    {
        [JsonProperty(PropertyName = "alliance_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "alliance_name")]
        public string Name { get; set; }
    }

    public class AllianceIcons
    {
        [JsonProperty(PropertyName = "applicationjson")]
        public Icon Data { get; set; }
    }

    public class Icon
    {
        [JsonProperty(PropertyName = "px128x128")]
        public string X128 { get; set; }

        [JsonProperty(PropertyName = "px64x64")]
        public string X64 { get; set; }
    }

}
