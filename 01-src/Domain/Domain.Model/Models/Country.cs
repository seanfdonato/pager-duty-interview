using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Models
{
	public class Country
	{
		[JsonPropertyName("name")]
		public CountryName Name { get; set; }

		[JsonPropertyName("region")]
		public string Region { get; set; }
	}

	public class CountryName
	{
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }
    }
}

