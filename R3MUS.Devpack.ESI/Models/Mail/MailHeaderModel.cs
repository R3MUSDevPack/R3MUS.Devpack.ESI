using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Mail
{
    public class MailHeaderModel
    {
        public long OwnerId { get; set; }
        [JsonProperty(PropertyName = "mail_id")]
        public long MailId { get; set; }
        [JsonProperty(PropertyName = "from")]
        public long SenderId { get; set; }
        [JsonProperty(PropertyName = "is_read")]
        public bool IsRead { get; set; }
        [JsonProperty(PropertyName = "labels")]
        public IEnumerable<int> Labels { get; set; }
        [JsonProperty(PropertyName = "recipients")]
        public IEnumerable<Recipient> Recipients { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime TimeStamp { get; set; }
    }
}
