using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Mail
{
    public class Recipient
    {
        [JsonProperty(PropertyName = "recipient_id")]
        public long RecipientId { get; set; }
        [JsonProperty(PropertyName = "recipient_type")]
        public string RecipientType { get; set; }
    }
}
