using System;
using Domain.Core.Interfaces;
using Infrastructure.Gateway.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Gateway.Extensions
{
	public static class Dependencies
	{
		public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection service)
		{
			service.AddScoped<ICountryClient, CountryClient>();

			return service;
		}
	}
}

