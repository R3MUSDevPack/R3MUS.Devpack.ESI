using Newtonsoft.Json;
using R3MUS.Devpack.ESI.Extensions;
using System;

namespace R3MUS.Devpack.ESI.Models.Character
{
	public class Detail
	{
		public long Id { get; set; }

		[JsonProperty(PropertyName = "ancestry_id")]
		public int AncestryId { get; set; }

		[JsonProperty(PropertyName = "birthday")]
		public DateTime Birthday { get; set; }

		[JsonProperty(PropertyName = "bloodline_id")]
		public int BloodlineId { get; set; }

		[JsonProperty(PropertyName = "corporation_id")]
		public long CorporationId { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "gender")]
		public string Gender { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "race_id")]
		public int RaceId { get; set; }

		public Detail()
		{
		}

		public Detail(long id)
		{
			Id = id;
			this.GetCharacter();
		}

        public Detail(string authToken)
        {
            var id = SingleSignOn.GetCharacterIdForToken(authToken);
            Id = id;
            this.GetCharacter();
            Id = id;
        }
	}
}
