using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class Icons
    {
        [JsonProperty(PropertyName = "px128x128")]
        public string X128 { get; set; }

        [JsonProperty(PropertyName = "px64x64")]
        public string X64 { get; set; }
    }
}
