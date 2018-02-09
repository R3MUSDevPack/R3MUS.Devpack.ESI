using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;

namespace R3MUS.Devpack.ESI.Models.Universe
{
    /// <summary>
    /// https://esi.tech.ccp.is/latest/universe/stations/60003760/?datasource=tranquility
    /// </summary>
    public class Station
    {
        [JsonProperty(PropertyName = "station_id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "type_id")]
        public int TypeId { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
        [JsonProperty(PropertyName = "system_id")]
        public int SystemId { get; set; }
        [JsonProperty(PropertyName = "reprocessing_efficiency")]
        public decimal ReprocessingEfficiency { get; set; }
        [JsonProperty(PropertyName = "reprocessing_stations_take")]
        public decimal ReprocessingStationsTake { get; set; }
        [JsonProperty(PropertyName = "max_dockable_ship_volume")]
        public long MaxDockableShipVolume { get; set; }
        [JsonProperty(PropertyName = "office_rental_cost")]
        public decimal OfficeRentalCost { get; set; }
        [JsonProperty(PropertyName = "services")]
        public string[] Services { get; set; }
        [JsonProperty(PropertyName = "owner")]
        public long Owner { get; set; }
        [JsonProperty(PropertyName = "race_id")]
        public int RaceId { get; set; }

        public Station()
        {
        }

        public Station(long id)
        {
            Id = id;
            this.GetStation();
        }
    }
}
