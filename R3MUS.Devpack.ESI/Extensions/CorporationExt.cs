using Corporation;
using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class CorporationExt
    {
        public static void GetCorporation(this Detail me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Constants.BaseURI, Constants.Corporations, me.Id.ToString(), Constants.BaseURITail);
            var obj = (Detail)Web.BaseRequest(reqUri).Deserialize(typeof(Detail));
            me.SetProperties(obj);
        }
    }
}
