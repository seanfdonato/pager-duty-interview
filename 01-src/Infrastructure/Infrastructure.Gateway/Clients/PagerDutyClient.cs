using System.Collections.Generic;
using Domain.Core.Interfaces;
using Domain.Models;
using Domain.Options;
using Microsoft.Extensions.Options;

namespace Infrastructure.Gateway.Clients
{
    public class PagerDutyClient : BaseClient, IPagerDutyClient
    {
        private readonly PagerDutyApiConfiguration _pagerDutyApi;

        public PagerDutyClient(IOptions<PagerDutyApiConfiguration> option)
        {
            _pagerDutyApi = option.Value;
        }

        public async Task<UserResponse> GetUserAsync(int limit, int offset)
        {
            var endpoint = new UriBuilder(_pagerDutyApi.AddressUri)
            {
                Path = "users",
                Query = $"limit={limit}&offset={offset}"
            };

            return await GetAsync<UserResponse>(endpoint.ToString(), _pagerDutyApi.AccessKey);
        }

        public async Task<List<ContactMethod>> GetUserContact(string id)
        {
            var endpoint = new UriBuilder(_pagerDutyApi.AddressUri)
            {
                Path = $"users/{id}/contact_methods",
            };

            return await GetAsync<List<ContactMethod>>(endpoint.ToString(), _pagerDutyApi.AccessKey);
        }
    }
}

