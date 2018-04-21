using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Corporation;
using System.Collections.Generic;

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

        public static IEnumerable<Contract> GetContracts(this Detail me, string clientId, string applicationKey, string authToken)
        {
            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));
            var obj = Web.BaseRequest(
                string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Corporations, me.Id.ToString(), Resources.Contracts, Resources.BaseURITail), 
                headers).Deserialize<IEnumerable<Contract>>();
            return obj;
        }

        public static KillList GetKills(this Detail me, string clientId, string applicationKey, string authToken)
        {
            var headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>(Resources.Authorization, string.Concat("Bearer ", authToken)));
            var obj = Web.BaseRequest(
                string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Corporations, me.Id.ToString(), Resources.Killmails, Resources.Recent),
                headers).Deserialize<KillList>();
            return obj;
        }
    }
}
