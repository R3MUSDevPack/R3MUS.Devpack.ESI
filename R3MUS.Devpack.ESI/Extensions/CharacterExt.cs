using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Character;
using R3MUS.Devpack.ESI.Models.Clones;
using R3MUS.Devpack.ESI.Models.Mail;
using R3MUS.Devpack.ESI.Models.Shared;
using R3MUS.Devpack.ESI.Models.Skills;
using R3MUS.Devpack.ESI.Models.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace R3MUS.Devpack.ESI.Extensions
{
    /// <summary>
    /// Methods to access character endpoints
    /// </summary>
    /// <checked-as-complete>
    /// Not complete
    /// </checked-as-complete>
    public static class CharacterExt
	{
		public static void GetCharacter(this Detail me)
		{
            var id = me.Id;
			var reqUri = string.Format("{0}/{1}/{2}/", Resources.BaseURI, Resources.Characters, me.Id.ToString());
			var obj = Web.BaseRequest(reqUri).Deserialize<Detail>();
			me.SetProperties(obj);
            me.Id = id;
		}

        public static IEnumerable<AgentsResearch> GetAgentsResearch(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.AgentsResearch);
            return Web.BaseRequest(reqUri).Deserialize<IEnumerable<AgentsResearch>>();
        }

        public static IEnumerable<Blueprint> GetBlueprints(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Blueprints);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<IEnumerable<Blueprint>>();
        }

        public static CorporationRolesModel GetRolesInCorporation(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Roles);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<CorporationRolesModel>();
        }

        public static IEnumerable<ChatChannel> GetChannels(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.ChatChannels);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<IEnumerable<ChatChannel>>();
        }

        public static IEnumerable<HistoricCorporationModel> GetEmploymentHistory(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.CorporationHistory);
            return Web.BaseRequest(reqUri).Deserialize<IEnumerable<HistoricCorporationModel>>();
        }

        public static IEnumerable<ContactModel> GetContacts(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Contacts, Resources.BaseURI);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<IEnumerable<ContactModel>>();
        }

        public static void GetCharacterByName(this Detail me)
        {
            var id = me.Name.GetCharacterIdByName();
            me.Id = id;
            me.GetCharacter();
            me.Id = id;
        }

        public static long GetCharacterIdByName(this string name)
        {
            var searchString = string.Format(Resources.CharacterSearchCategories, (HttpUtility.UrlPathEncode(name)));
            var reqUri = string.Format("{0}/{1}/?{2}", Resources.BaseURI, Resources.Search, searchString);
            return Web.BaseRequest(reqUri).Deserialize<CharacterSearchResponse>().Characters.First();
        }

        public static CharacterNames GetCharacterNames(this IdList me)
        {
            var toonNames = new CharacterNames()
            {
                CharacterDetail = new List<Summary>()
            };

            me.Ids.ForEach(id => {
                try
                {
                    var characterDetail = new Detail(id);
                    toonNames.CharacterDetail.Add(new Summary() { Id = id, Name = characterDetail.Name, CorporationId = characterDetail.CorporationId });
                }
                catch (Exception ex)
                {
                    toonNames.CharacterDetail.Add(new Summary() { Id = id, Name = "Character Not Found" });
                }
            });

            return toonNames;
        }

        public static List<MailHeaderModel> GetMails(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Mail, Resources.BaseURITail);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            var results = Web.BaseRequest(reqUri, headers).Deserialize<List<MailHeaderModel>>();
            results.ForEach(item => item.OwnerId = me.Id);

            return results;
        }

        public static MailDetailModel GetMail(this Detail me, long mailId, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}/?{5}", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Mail, mailId.ToString(), Resources.BaseURITail);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<MailDetailModel>();
        }

        public static SkillResponse GetTrainedSkills(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Skills, Resources.BaseURITail);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<SkillResponse>();
        }

        public static List<SkillQueueItem> GetTrainingQueue(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.SkillQueue, Resources.BaseURITail);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<List<SkillQueueItem>>();
        }

        public static List<WalletJournalEntry> GetWalletJournal(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Wallet, Resources.Journal);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<List<WalletJournalEntry>>();
        }
        public static List<WalletTransactionEntry> GetWalletTransactions(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Wallet, Resources.Transactions);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<List<WalletTransactionEntry>>();
        }

        public static CloneData GetCloneInformation(this Detail me, string authToken)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Clones);

            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));

            return Web.BaseRequest(reqUri, headers).Deserialize<CloneData>();
        }
    }
}
