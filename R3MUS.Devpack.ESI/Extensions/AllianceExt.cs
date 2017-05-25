using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.Core;
using System.Collections.Generic;
using R3MUS.Devpack.ESI.Models.Alliance;
using System.Net;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class AllianceExt
    {
        public static Alliances GetAlliances(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/?{2}", Constants.BaseURI, Constants.Alliances, Constants.BaseURITail);

            return new Alliances() { AllianceIds = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>)) };
        }

        public static AllianceNames GetAllianceNames(this Alliances me)
        {
            var idStr = WebUtility.UrlEncode(string.Join(",", me.AllianceIds));
            var reqUri = string.Format("{0}/{1}/{2}/?{3}={4}&{5}", Constants.BaseURI, Constants.Alliances, Constants.Names,
                Constants.AllianceIds, idStr, Constants.BaseURITail);
            return new AllianceNames() { AllianceDetail = (Summary[])Web.BaseRequest(reqUri).Deserialize(typeof(Summary[])) };
        }

        public static void GetCorporationIds(this Detail me)
        {
            if (me.Id > 0)
            {
                var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}", Constants.BaseURI, Constants.Alliances, me.Id.ToString(),
                    Constants.Corporations, Constants.BaseURITail);

                me.CorporationIds = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>));
            }
            else
            {
                me.CorporationIds = new List<long>();
            }
        }

        public static void GetAlliance(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/?{3}", Constants.BaseURI, Constants.Alliances, me.Id.ToString(), Constants.BaseURITail);

            var obj = (Detail)Web.BaseRequest(reqUri).Deserialize(typeof(Detail));
            me.SetProperties(obj);
        }

        public static void GetAllianceIcons(this Detail me)
        {
            if (me.Id > 0)
            {
                var reqUri = string.Format("{0}/{1}/{2}/{3}", Constants.BaseURI, Constants.Alliances, me.Id.ToString(), Constants.BaseURITail);

                var obj = (AllianceIcons)Web.BaseRequest(reqUri).Deserialize(typeof(AllianceIcons));
                me.Icons = obj.Icons;
            }
            else
            {
                me.Icons = new Models.Shared.Icons();
            }
        }
    }
}
