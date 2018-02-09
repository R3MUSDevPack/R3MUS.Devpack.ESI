using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Shared;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Extensions
{
	public static class WarExt
    {
        public static IdList GetWars()
        {
            var reqUri = string.Format("{0}/{1}/?{2}", Resources.BaseURI, Resources.Wars, Resources.BaseURITail);

            return new IdList() { Ids = Web.BaseRequest(reqUri).Deserialize<List<long>>() };
        }
        public static void GetWar(this War me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/?{3}", Resources.BaseURI, Resources.Wars, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<War>();
            me.SetProperties(obj);
        }
    }
}
