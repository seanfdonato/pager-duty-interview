using System;
using Domain.Core.Interfaces;
using Infrastructure.Gateway.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Gateway.Extensions
{
	public static class ServiceColletionExtensions
    {
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection service)
		{
			service.AddScoped<IPagerDutyClient, PagerDutyClient>();

			return service;
		}
	}
}

