﻿using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.ESI.Models.Shared;
using R3MUS.Devpack.ESI.Models.Universe;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class UniverseExt
    {
        public static IdList GetAlliances(this ItemType me)
        {
            var reqUri = string.Format("{0}/{1}/?{2}", Constants.BaseURI, Constants.Universe, Constants.Types, Constants.BaseURITail);

            return new IdList() { Ids = (List<long>)Web.BaseRequest(reqUri).Deserialize(typeof(List<long>)) };
        }

        public static void GetItemType(this ItemType me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Constants.BaseURI, Constants.Universe, Constants.Types, me.Id.ToString(), Constants.BaseURITail);

            var obj = (ItemType)Web.BaseRequest(reqUri).Deserialize(typeof(ItemType));
            me.SetProperties(obj);
        }
    }
}
