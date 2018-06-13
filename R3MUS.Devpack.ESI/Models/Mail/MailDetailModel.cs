using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Mail
{
    public class MailDetailModel
    {
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
        [JsonProperty(PropertyName = "from")]
        public long SenderId { get; set; }
        [JsonProperty(PropertyName = "labels")]
        public IEnumerable<int> Labels { get; set; }
        [JsonProperty(PropertyName = "read")]
        public bool IsRead { get; set; }
        [JsonProperty(PropertyName = "recipients")]
        public IEnumerable<Recipient> Recipients { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime TimeStamp { get; set; }
    }
}
