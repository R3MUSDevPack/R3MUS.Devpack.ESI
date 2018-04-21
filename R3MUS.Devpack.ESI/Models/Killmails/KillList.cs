using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models
{
    public class KillList
    {
        public IEnumerable<Kill> Kills { get; set; }
    }
    
    public class Kill
    {
        [JsonProperty(PropertyName = "killmail_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "killmail_hash")]
        public string Hash { get; set; }
    }

}
