using System;
using Domain.Core.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryClient _countryClient;

        public CountryService(ICountryClient countryClient)
        {
            _countryClient = countryClient;
        }

        public async Task<List<Country>> Get(string name)
        {
            return await _countryClient.Get(name);
        }
    }
}

