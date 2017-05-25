using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using R3MUS.Devpack.ESI.Models.Shared;
using System;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Alliance
{
    public partial class Detail
    {
        private List<long> _corporationIds;
        private List<Corporation.Detail> _corps = new List<Corporation.Detail>();

        private Icons _icons;

        public long Id { get; set; }

        [JsonProperty(PropertyName = "alliance_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ticker")]
        public string Ticker { get; set; }

        [JsonProperty(PropertyName = "date_founded")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "executor_corp")]
        public long ExecutorCorpId { get; set; }

        [IgnoreDataMember]
        public virtual List<long> CorporationIds
        {
            get
            {
                if ((_corporationIds == null) || (this.CorporationIds.Count == 0)) { this.GetCorporationIds(); }
                return _corporationIds;
            }
            set
            {
                _corporationIds = value;
            }
        }

        [IgnoreDataMember]
        public virtual Icons Icons
        {
            get
            {
                if (_icons == null) { this.GetAllianceIcons(); }
                return _icons;
            }
            set
            {
                _icons = value;
            }
        }

        public Detail()
        {
        }
        public Detail(long id)
        {
            Id = id;
            this.GetAlliance();
        }
    }
}
