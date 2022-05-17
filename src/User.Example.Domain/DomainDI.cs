using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Domain
{
    public static class DomainDI
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services.AddTransient<IUseCase<UserEntity, bool>, CreateUserUseCase>()
                    .AddTransient<IUseCase<string, bool>, DeleteUserUseCase>()
                    .AddTransient<IUseCase<string, IEnumerable<UserEntity>>, GetAllUsersUseCase>()
                    .AddTransient<IUseCase<string, UserEntity>, GetUserByIdUseCase>()
                    .AddTransient<IUseCase<UserEntity, UserEntity>, UpdateUserUseCase>();
        }
    }
}
