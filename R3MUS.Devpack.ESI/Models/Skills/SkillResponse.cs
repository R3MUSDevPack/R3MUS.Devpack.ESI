using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Models.Skills
{
    public class SkillResponse
    {
        [JsonProperty(PropertyName = "total_sp")]
        public long TotalSkillPoints { get; set; }
        [JsonProperty(PropertyName = "skills")]
        public IEnumerable<TrainedSkill> TrainedSkills { get; set; }
    }

    public class TrainedSkill
    {
        [JsonProperty(PropertyName = "skill_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "active_skill_level")]
        public int ActiveLevel { get; set; }
        [JsonProperty(PropertyName = "trained_skill_level")]
        public int TrainedLevel { get; set; }
        [JsonProperty(PropertyName = "skillpoints_in_skill")]
        public int PointsInSkill { get; set; }
    }
}
