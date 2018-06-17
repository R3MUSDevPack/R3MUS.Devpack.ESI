using Newtonsoft.Json;
using System;

namespace R3MUS.Devpack.ESI.Models.Wallet
{
    public class WalletJournalEntry
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public float Amount { get; set; }
        [JsonProperty(PropertyName = "balance")]
        public float Balance { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Timestamp { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "first_party_id")]
        public long FirstPartyId { get; set; }
        [JsonProperty(PropertyName = "ref_type")]
        public string ReferenceType { get; set; }
        [JsonProperty(PropertyName = "second_party_id")]
        public long SecondPartyId { get; set; }
        [JsonProperty(PropertyName = "context_id")]
        public long ContextId { get; set; }
        [JsonProperty(PropertyName = "context_id_type")]
        public string ContextIdType { get; set; }
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        [JsonProperty(PropertyName = "tax")]
        public float Tax { get; set; }
        [JsonProperty(PropertyName = "tax_receiver_id")]
        public long TaxReceiverId { get; set; }
    }    
}
