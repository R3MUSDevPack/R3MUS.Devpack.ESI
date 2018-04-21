using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.ESI.Models.Shared;
using R3MUS.Devpack.ESI.Models.Universe;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class UniverseExt
    {
        public static IdList GetItemIds(this ItemType me)
        {
            var reqUri = string.Format("{0}/{1}/{2}", Resources.BaseURI, Resources.Universe, Resources.Types, Resources.BaseURITail);

            return new IdList() { Ids = Web.BaseRequest(reqUri).Deserialize<List<long>>() };
        }

        public static void GetItemType(this ItemType me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Universe, Resources.Types, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<ItemType>();
            me.SetProperties(obj);
        }

        public static void GetStation(this Station me)
        {
            var id = me.Id;
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Universe, Resources.Stations, id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<Station>();
            me.SetProperties(obj);
            me.Id = id;
        }

        public static void GetStructure(this Structure me, List<KeyValuePair<string, string>> authorisationHeaders)
        {
            var id = me.Id;
            var reqUri = string.Format("{0}/{1}/{2}/{3}/", Resources.BaseURI, Resources.Universe, Resources.Structures, id.ToString());

            var obj = Web.BaseRequest(reqUri, authorisationHeaders).Deserialize<Structure>();
            me.SetProperties(obj);
            me.Id = id;
        }

        public static void GetSolarSystem(this SolarSystem me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Universe, Resources.Systems, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<SolarSystem>();
            me.SetProperties(obj);
        }

        public static void GetConstellation(this Constellation me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Universe, Resources.Constellations, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<Constellation>();
            me.SetProperties(obj);
        }

        public static void GetRegion(this Region me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}", Resources.BaseURI, Resources.Universe, Resources.Regions, me.Id.ToString(), Resources.BaseURITail);

            var obj = Web.BaseRequest(reqUri).Deserialize<Region>();
            me.SetProperties(obj);
        }
    }
}
