using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class HistoricCorporationModel
    {
        [JsonProperty(PropertyName = "corporation_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "record_id")]
        public int RecordId { get; set; }
        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }
    }
}
