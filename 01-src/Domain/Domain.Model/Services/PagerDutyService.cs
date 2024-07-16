using Domain.Core.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Services
{
    public class PagerDutyService : IPagerDutyService
    {
        private readonly IPagerDutyClient _pagerDutyClient;

        public PagerDutyService(IPagerDutyClient countryClient)
        {
            _pagerDutyClient = countryClient;
        }

        public async Task<UserResponse> GetUserAsync(int limit,int offset)
        {
            return await _pagerDutyClient.GetUserAsync(limit,offset);
        }

        public async Task<List<ContactMethod>> GetUserContact(string id)
        {
            return await _pagerDutyClient.GetUserContact(id);
        }
    }
}

