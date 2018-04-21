﻿using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models.Character;
using R3MUS.Devpack.ESI.Models.Shared;
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

        public static IEnumerable<AgentsResearch> GetAgentsResearch(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.AgentsResearch);
            return Web.BaseRequest(reqUri).Deserialize<IEnumerable<AgentsResearch>>();
        }

        public static IEnumerable<Blueprint> GetBlueprints(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.Blueprints);
            return Web.BaseRequest(reqUri).Deserialize<IEnumerable<Blueprint>>();
        }

        public static IEnumerable<ChatChannel> GetChannels(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Characters, me.Id.ToString(), Resources.ChatChannels);
            return Web.BaseRequest(reqUri).Deserialize<IEnumerable<ChatChannel>>();
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
            var idStr = WebUtility.UrlEncode(string.Join(",", me.Ids));
            var reqUri = string.Format("{0}/{1}/{2}/?{3}={4}&{5}", Resources.BaseURI, Resources.Characters, Resources.Names,
                Resources.CharacterIds, idStr, Resources.BaseURITail);
            return new CharacterNames() { CharacterDetail = Web.BaseRequest(reqUri).Deserialize<Summary[]>() };
        }
    }
}
