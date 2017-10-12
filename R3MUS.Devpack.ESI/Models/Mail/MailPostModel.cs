using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Mail
{
    public class MailPostModel
    {
        [JsonProperty(PropertyName = "approved_cost")]
        public int ApprovedCost { get; set; }
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
        [JsonProperty(PropertyName = "recipients")]
        public Recipient[] Recipients { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
    }
}
