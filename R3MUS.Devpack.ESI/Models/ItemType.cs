using Newtonsoft.Json;

namespace R3MUS.Devpack.ESI.Models
{
    public class ItemType
    {
        [JsonProperty(PropertyName = "type_id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "published")]
        public bool Published { get; set; }

        [JsonProperty(PropertyName = "group_id")]
        public long Group_Id { get; set; }

        [JsonProperty(PropertyName = "radius")]
        public long Radius { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public long Volume { get; set; }

        [JsonProperty(PropertyName = "capacity")]
        public long Capacity { get; set; }

        [JsonProperty(PropertyName = "portion_size")]
        public long Portion_Size { get; set; }

        [JsonProperty(PropertyName = "mass")]
        public float Mass { get; set; }

        [JsonProperty(PropertyName = "graphic_id")]
        public long Graphic_Id { get; set; }

        [JsonProperty(PropertyName = "dogma_attributes")]
        public Dogma_Attributes[] Dogma_Attributes { get; set; }

        [JsonProperty(PropertyName = "dogma_effects")]
        public Dogma_Effects[] Dogma_Effects { get; set; }

        public ItemType()
        {

        }
        public ItemType(long id)
        {
            Id = id;
            //this.GetItemType();
        }
    }

    public class Dogma_Attributes
    {

        [JsonProperty(PropertyName = "attribute_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "value")]
        public float Value { get; set; }
    }

    public class Dogma_Effects
    {

        [JsonProperty(PropertyName = "effect_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "is_default")]
        public bool IsDefault { get; set; }
    }

}
