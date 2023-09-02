using Domain.Core.Interfaces;
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
    }
}

