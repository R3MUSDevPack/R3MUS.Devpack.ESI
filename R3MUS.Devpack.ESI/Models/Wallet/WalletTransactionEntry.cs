using Newtonsoft.Json;
using System;

namespace R3MUS.Devpack.ESI.Models.Wallet
{
    public class WalletTransactionEntry
    {
        [JsonProperty(PropertyName = "transaction_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "client_id")]
        public long ClientId { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Timestamp { get; set; }
        [JsonProperty(PropertyName = "is_buy")]
        public bool IsBuy { get; set; }
        [JsonProperty(PropertyName = "is_personal")]
        public bool IsPersonal { get; set; }
        [JsonProperty(PropertyName = "journal_ref_id")]
        public long JournalReferenceId { get; set; }
        [JsonProperty(PropertyName = "location_id")]
        public long LocationId { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
        [JsonProperty(PropertyName = "type_id")]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "unit_price")]
        public float UnitPrice { get; set; }
    }
}
