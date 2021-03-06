﻿using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.Core;
using System.Collections.Generic;
using R3MUS.Devpack.ESI.Models.Alliance;
using System.Net;
using R3MUS.Devpack.ESI.Models.Shared;

namespace R3MUS.Devpack.ESI.Extensions
{
    /// <summary>
    /// Methods to access alliance endpoints
    /// </summary>
    /// <checked-as-complete>
    /// 2018-04-21
    /// </checked-as-complete>
    public static class AllianceExt
    {
        public static IdList GetAlliances(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/?{2}",
				Resources.BaseURI, Resources.Alliances, Resources.BaseURITail);

            return new IdList() { Ids = Web.BaseRequest(reqUri).Deserialize<List<long>>() };
        }

        public static void GetAlliance(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/?{3}", Resources.BaseURI, Resources.Alliances, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<Detail>();
            me.SetProperties(obj);
        }

        public static void GetCorporationIds(this Detail me)
        {
            if (me.Id > 0)
            {
                var reqUri = string.Format("{0}/{1}/{2}/{3}/{4}", Resources.BaseURI, Resources.Alliances, me.Id.ToString(),
					Resources.Corporations, Resources.BaseURITail);

                me.CorporationIds = Web.BaseRequest(reqUri).Deserialize<List<long>>();
            }
            else
            {
                me.CorporationIds = new List<long>();
            }
        }

        public static void GetAllianceIcons(this Detail me)
        {
            if (me.Id > 0)
            {
                var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Alliances, me.Id.ToString(), Resources.BaseURITail);

                var obj = Web.BaseRequest(reqUri).Deserialize<AllianceIcons>();
                me.Icons = obj.Icons;
            }
            else
            {
                me.Icons = new Models.Shared.Icons();
            }
        }

        public static AllianceNames GetAllianceNames(this IdList me)
        {
            var idStr = WebUtility.UrlEncode(string.Join(",", me.Ids));
            var reqUri = string.Format("{0}/{1}/{2}/?{3}={4}&{5}", Resources.BaseURI, Resources.Alliances, Resources.Names,
				Resources.AllianceIds, idStr, Resources.BaseURITail);
            return new AllianceNames() { AllianceDetail = Web.BaseRequest(reqUri).Deserialize<Summary[]>() };
        }
    }
}
