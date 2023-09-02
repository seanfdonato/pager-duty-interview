using System;
using Domain.Core.Interfaces;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ServiceColletionExtensions
    {
        public static IServiceCollection AddDomainDependencies(this IServiceCollection service)
        {
            service.AddScoped<IPagerDutyService, PagerDutyService>();

            return service;
        }
    }
}

