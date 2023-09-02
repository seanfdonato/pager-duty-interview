using Domain.Options;

namespace Application.WebApi.Extensions
{
    public static class Configuration
    {
        public static void ConfigureSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<PagerDutyApiConfiguration>().Bind(
                configuration.GetSection(nameof(PagerDutyApiConfiguration)));
        }
    }
}