using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Models.Shared;
using System;

namespace R3MUS.Devpack.ESI.Models.Corporation
{
    public partial class Contract : IHasLongId
    {
        [JsonProperty(PropertyName = "contract_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "issuer_id")]
        public long IssuerId { get; set; }
        [JsonProperty(PropertyName = "issuer_corporation_id")]
        public int IssuerCorporationId { get; set; }
        [JsonProperty(PropertyName = "assignee_id")]
        public long AssigneeId { get; set; }
        [JsonProperty(PropertyName = "acceptor_id")]
        public long AcceptorId { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "for_corporation")]
        public bool AcceptedForCorporation { get; set; }
        [JsonProperty(PropertyName = "availability")]
        public string Availability { get; set; }
        [JsonProperty(PropertyName = "date_issued")]
        public DateTime Issued { get; set; }
        [JsonProperty(PropertyName = "date_expired")]
        public DateTime Expired { get; set; }
        [JsonProperty(PropertyName = "start_location_id")]
        public long StartEndpointId { get; set; }
        [JsonProperty(PropertyName = "end_location_id")]
        public long EndEndpointId { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "date_accepted")]
        public DateTime Accepted { get; set; }
        [JsonProperty(PropertyName = "days_to_complete")]
        public int DaysToComplete { get; set; }
        [JsonProperty(PropertyName = "date_completed")]
        public DateTime Completed { get; set; }
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }
        [JsonProperty(PropertyName = "reward")]
        public decimal Reward { get; set; }
        [JsonProperty(PropertyName = "collateral")]
        public decimal Collateral { get; set; }
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }
    }
}
