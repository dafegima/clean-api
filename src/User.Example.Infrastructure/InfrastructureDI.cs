using Microsoft.Extensions.DependencyInjection;
using User.Example.Domain.Interfaces;
using User.Example.Infrastructure.Repositories;

namespace User.Example.Infrastructure
{
    public static class InfrastructureDI
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
