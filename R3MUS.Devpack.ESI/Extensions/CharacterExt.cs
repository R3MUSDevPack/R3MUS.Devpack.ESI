using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models.Character;
using R3MUS.Devpack.ESI.Models.Shared;
using System;
using System.Net;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class CharacterExt
	{
		public static void GetCharacter(this Detail me)
		{
			var reqUri = string.Format("{0}/{1}/{2}/", Resources.BaseURI, Resources.Characters, me.Id.ToString());
			var obj = Web.BaseRequest(reqUri).Deserialize<Detail>();
			me.SetProperties(obj);
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
