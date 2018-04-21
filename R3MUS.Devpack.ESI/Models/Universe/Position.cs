using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    public class Position
    {
        [JsonProperty(PropertyName = "x")]
        public float X { get; set; }
        [JsonProperty(PropertyName = "")]
        public float Y { get; set; }
        [JsonProperty(PropertyName = "z")]
        public float Z { get; set; }
    }
}
