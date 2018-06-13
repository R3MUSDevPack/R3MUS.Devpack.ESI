using Newtonsoft.Json;
using System;

namespace R3MUS.Devpack.ESI.Models.Skills
{
    public class SkillQueueItem
    {
        [JsonProperty(PropertyName = "skill_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }
        [JsonProperty(PropertyName = "finish_date")]
        public DateTime EndDate { get; set; }
        [JsonProperty(PropertyName = "finished_level")]
        public int FinishedLevel { get; set; }
        [JsonProperty(PropertyName = "level_end_sp")]
        public long LevelEndSp { get; set; }
        [JsonProperty(PropertyName = "level_start_sp")]
        public int LevelStartSp { get; set; }
        [JsonProperty(PropertyName = "queue_position")]
        public int QueuePosition { get; set; }
        [JsonProperty(PropertyName = "training_start_sp")]
        public int TrainingStartSp { get; set; }
    }
}
