using Newtonsoft.Json;
using System;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class Notification
    {
        [JsonProperty(PropertyName = "notification_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "sender_id")]
        public long SenderId { get; set; }
        [JsonProperty(PropertyName = "sender_type")]
        public string SenderType { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class NotificationTypes
    {
        public const string KillReportFinalBlow = "KillReportFinalBlow";
        public const string NPCStandingsLost = "NPCStandingsLost";
        public const string StructureFuelAlert = "StructureFuelAlert";
        public const string StructureUnderAttack = "StructureUnderAttack";
        public const string CorpAppNewMsg = "KillReportFinalBlow";
        public const string CharAppWithdrawMsg = "KillReportFinalBlow";

        public const string CloneActivationMsg2 = "CloneActivationMsg2";
        public const string InsurancePayoutMsg = "InsurancePayoutMsg";
        public const string KillReportVictim = "KillReportVictim";
        public const string CorpAllBillMsg = "CorpAllBillMsg";
        public const string CharAppAcceptMsg = "CharAppAcceptMsg";
        public const string CharLeftCorpMsg = "CharLeftCorpMsg";

        public const string StructureUnanchoring = "StructureUnanchoring";
        public const string JumpCloneDeletedMsg2 = "JumpCloneDeletedMsg2";
        public const string MoonminingExtractionCancelled = "MoonminingExtractionCancelled";
        public const string MoonminingAutomaticFracture = "MoonminingAutomaticFracture";
        public const string StructureWentHighPower = "CharLeftCorpMsg";
        public const string MoonminingExtractionFinished = "MoonminingExtractionFinished";

        public const string StructureWentLowPower = "StructureWentLowPower";
        public const string StructureServicesOffline = "StructureServicesOffline";
        public const string MoonminingExtractionStarted = "MoonminingExtractionStarted";
        public const string InsuranceIssuedMsg = "InsuranceIssuedMsg";
        public const string SeasonalChallengeCompleted = "SeasonalChallengeCompleted";
        public const string StructureItemsDelivered = "StructureItemsDelivered";
    }
}
