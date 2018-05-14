using Newtonsoft.Json;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Models.Character
{
    public class CorporationRolesModel
    {
        [JsonProperty(PropertyName = "roles")]
        public IEnumerable<string> Roles { get; set; }
        [JsonProperty(PropertyName = "roles_at_base")]
        public IEnumerable<string> RolesAtBase { get; set; }
        [JsonProperty(PropertyName = "roles_at_hq")]
        public IEnumerable<string> RolesAtHQ { get; set; }
        [JsonProperty(PropertyName = "roles_at_other")]
        public IEnumerable<string> RolesAtOther { get; set; }
    }
}
