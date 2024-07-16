using System;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class ContactMethod
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("country_code")]
        public int CountryCode { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}

