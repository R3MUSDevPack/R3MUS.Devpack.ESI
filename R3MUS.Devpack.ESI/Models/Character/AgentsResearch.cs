using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class AgentsResearch
    {
        [JsonProperty(PropertyName = "agent_id")]
        public int AgentId { get; set; }
        [JsonProperty(PropertyName = "skill_type_id")]
        public int SkillTypeId { get; set; }
        [JsonProperty(PropertyName = "started_at")]
        public DateTime Start { get; set; }
        [JsonProperty(PropertyName = "points_per_day")]
        public decimal PointsPerDay { get; set; }
        [JsonProperty(PropertyName = "remainder_points")]
        public decimal RemainderPoints { get; set; }
    }
}
