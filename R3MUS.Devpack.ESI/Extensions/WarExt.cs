﻿using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Shared;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class WarExt
    {
        public static IdList GetWars()
        {
            var reqUri = string.Format("{0}/{1}/?{2}", Constants.BaseURI, Constants.Wars, Constants.BaseURITail);

            return new IdList() { Ids = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>)) };
        }
        public static void GetWar(this War me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/?{3}", Constants.BaseURI, Constants.Wars, me.Id.ToString(), Constants.BaseURITail);

            var obj = (War)Web.BaseRequest(reqUri).Deserialize(typeof(War));
            me.SetProperties(obj);
        }
    }
}
