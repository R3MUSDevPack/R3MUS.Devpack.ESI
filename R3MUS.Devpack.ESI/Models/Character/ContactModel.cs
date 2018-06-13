using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class ContactModel
    {
        [JsonProperty(PropertyName = "contact_id")]
        public long ContactId { get; set; }
        [JsonProperty(PropertyName = "contact_type")]
        public string ContactType { get; set; }
        [JsonProperty(PropertyName = "standing")]
        public decimal Standing { get; set; }
    }
}
