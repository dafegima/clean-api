using User.Example.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace User.Example.API.Extensions
{
    public static class SettingsExtensions
    {
        public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<DBSettings>(configuration.GetSection(nameof(DBSettings)));
        }
    }
}
