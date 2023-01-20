using SmsProvider.Costracts;
using SmsProvider.SmsServices;

namespace SmsProvider
{
    public static class ConfigureService
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<SmsProviderManager>();

            return services;
        }
    }
}
