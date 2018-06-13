using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Corporation;
using R3MUS.Devpack.ESI.Models.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class CorporationExt
    {
        public static void GetCorporation(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/?{3}", Resources.BaseURI, Resources.Corporations, me.Id.ToString(), Resources.BaseURITail);
            var obj = Web.BaseRequest(reqUri).Deserialize<Detail>();
            me.SetProperties(obj);
        }

        public static IEnumerable<Contract> GetContracts(this Detail me, string authToken)
        {
            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));
            var obj = Web.BaseRequest(
                string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Corporations, me.Id.ToString(), Resources.Contracts, Resources.BaseURITail), 
                headers).Deserialize<IEnumerable<Contract>>();
            return obj;
        }

        public static KillList GetKills(this Detail me, string authToken)
        {
            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));
            var obj = Web.BaseRequest(
                string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Corporations, me.Id.ToString(), Resources.Killmails, Resources.Recent),
                headers).Deserialize<KillList>();
            return obj;
        }

        public static CorporationNames GetCorporationNames(this IdList me)
        {
            var idStr = WebUtility.UrlEncode(string.Join(",", me.Ids));                        
            var reqUri = string.Format("{0}/{1}/{2}/?{3}={4}&{5}", Resources.BaseURI, Resources.Corporations, Resources.Names,
                Resources.CorporationIds, idStr, Resources.BaseURITail);
            return new CorporationNames() { CorporationDetail = Web.BaseRequest(reqUri).Deserialize<Summary[]>() };
        }

        public static Summary GetCorporationDetailsByName(this string me)
        {
            var reqUri = string.Format("{0}/{1}/?{2}={3}&{4}={5}&strict-true", Resources.BaseURI, Resources.Search,
                Resources.Categories, Resources.Corporation, Resources.Search, WebUtility.UrlEncode(me));
            var result = Web.BaseRequest(reqUri).Deserialize<SearchResponse>();
            if (result.Corporations != null && result.Corporations.Count > 0)
            {
                var idList = new IdList() { Ids = result.Corporations };
                return idList.GetCorporationNames().CorporationDetail.First();
            }
            throw new KeyNotFoundException();
        }

        public static CorporationNames GetMultipleCorporationDetailsByName(this string me)
        {
            var reqUri = string.Format("{0}/{1}/?{2}={3}&{4}={5}&strict-false", Resources.BaseURI, Resources.Search, 
                Resources.Categories, Resources.Corporation, WebUtility.UrlEncode(me));
            var result = Web.BaseRequest(reqUri).Deserialize<SearchResponse>();
            if (result.Corporations != null && result.Corporations.Count > 0)
            {
                var idList = new IdList() { Ids = result.Corporations };
                return idList.GetCorporationNames();
            }
            throw new KeyNotFoundException();
        }
    }
}
