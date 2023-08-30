using System;
using Domain.Extensions;
using Infrastructure.Gateway.Extensions;

namespace Application.WebApi.Extensions
{
    internal static class Dependencies
    {
        internal static void AddDependencies(this IServiceCollection services)
        {
            services.AddInfrastructureDependencies();
            services.AddDomainDependencies();

        }
    }
}

