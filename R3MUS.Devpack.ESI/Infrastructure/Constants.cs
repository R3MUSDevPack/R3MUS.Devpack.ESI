using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Infrastructure
{
    static class Constants
    { 
        public static string BaseURI = "https://esi.tech.ccp.is/latest";
        public static string BaseURITail = "?datasource=tranquility";
        public static string BaseTailExtra = "&language=en-us";

        public static string Universe = "universe";
        public static string Regions = "regions";
        public static string Constellations = "constellations";
        public static string Systems = "systems";
        public static string Types = "types";
        public static string Wars = "wars";
        public static string Corporations = "corporations";
        public static string Alliances = "alliances";
        public static string Names = "names";
        public static string Icons = "icons";
    }
}
