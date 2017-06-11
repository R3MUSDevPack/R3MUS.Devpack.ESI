using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.ESI.Models;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class ItemTypeExt
    {
        public static void GetItemType(this ItemType me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Constants.BaseURI, Constants.Universe, Constants.Types, me.Id.ToString(), Constants.BaseURITail);

            var obj = (ItemType)Web.BaseRequest(reqUri).Deserialize(typeof(ItemType));
            me.SetProperties(obj);
        }

    }
}
