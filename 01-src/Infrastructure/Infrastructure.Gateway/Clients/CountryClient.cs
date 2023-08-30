using System;
using System.IO;
using System.Text.Json;
using Domain.Core.Interfaces;
using Domain.Models;

namespace Infrastructure.Gateway.Clients
{
    public class CountryClient : ICountryClient
    {
        private static readonly Uri uri = new("https://restcountries.com/v3.1/");
        private static readonly HttpClient client = new();

        public async Task<List<Country>> Get(string name)
        {
            var url = new Uri(uri, $"name/{name}");

            var countries = new List<Country>();

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                if (content is not null)
                {
                    countries = JsonSerializer.Deserialize<List<Country>>(content);
                }

            }

            return countries;
        }
    }
}

