using System;
using System.Text.Json.Serialization;

namespace Domain.Models
{

	public class UserResponse
	{
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("users")]
        public List<User> Users { get; set; } = new List<User>();
    }

    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; } = string.Empty;

        [JsonPropertyName("color")]
        public string Color { get; set; } = string.Empty;

        [JsonPropertyName("job_title")]
        public string JobTitle { get; set; } = string.Empty;

        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; }

        [JsonPropertyName("contact_methods")]
        public List<Contact> Contacts { get; set; }
    }

    public class Team
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;
    }

    public class Contact
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = string.Empty;
    }
}

