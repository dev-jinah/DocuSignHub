using Microsoft.Extensions.DependencyInjection;
using backend.Services;
using backend.Repositories;

namespace backend.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherService, WeatherService>();
            services.AddScoped<IWeatherRepository, WeatherRepository>();
        }
    }
}
