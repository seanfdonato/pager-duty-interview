using System;
using Domain.Extensions;
using Infrastructure.Gateway.Extensions;

namespace Application.WebApi.Extensions
{
    internal static class DependencyInjection
    {
        internal static void AddDependencies(this IServiceCollection services)
        {
            services.AddInfrastructureDependencies();
            services.AddDomainDependencies();
        }
    }
}

