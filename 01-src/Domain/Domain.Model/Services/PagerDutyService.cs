using Domain.Core.Interfaces;
using Domain.Interfaces;

namespace Domain.Services
{
    public class PagerDutyService : IPagerDutyService
    {
        private readonly IPagerDutyClient _pagerDutyClient;

        public PagerDutyService(IPagerDutyClient countryClient)
        {
            _pagerDutyClient = countryClient;
        }
    }
}

