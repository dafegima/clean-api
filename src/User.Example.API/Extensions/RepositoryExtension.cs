using User.Example.Domain.Interfaces;
using User.Example.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace User.Example.API.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
