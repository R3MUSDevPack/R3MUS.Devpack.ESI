using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Shared
{
    public class RefreshTokenRequestModel
    {
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
