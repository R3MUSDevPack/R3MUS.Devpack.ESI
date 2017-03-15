using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.Core;
using System.Collections.Generic;
using System.Linq;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class AllianceExt
    {
        public static Alliances GetAlliances()
        {
            var reqUri = string.Format("{0}/{1}/{2}", Constants.BaseURI, Constants.Alliances, Constants.BaseURITail);

            return new Alliances() { AllianceIds = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>)) };
        }

        public static AllianceNames GetAllianceNames(this Alliances me)
        {
            var idStr = string.Join(",", me.AllianceIds);
            var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}", Constants.BaseURI, Constants.Alliances, Constants.Names,
                idStr, Constants.BaseURITail);
            return (AllianceNames)Web.BaseRequest(reqUri).Deserialize(typeof(AllianceNames));
        }

        public static Corporations GetCorporationIds(this Alliance me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}", Constants.BaseURI, Constants.Alliances, me.Id.ToString(), 
                Constants.Corporations, Constants.BaseURITail);

            return new Corporations() { CorpIds = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>)) };
        }

        public static void GetAlliance(this Alliance me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Constants.BaseURI, Constants.Alliances, me.Id.ToString(), Constants.BaseURITail);

            var obj = (Alliance)Web.BaseRequest(reqUri).Deserialize(typeof(Alliance));
            me.SetProperties(obj);
        }
    }
}
