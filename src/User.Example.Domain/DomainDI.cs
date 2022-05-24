using Microsoft.Extensions.DependencyInjection;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Domain
{
    public static class DomainDI
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services.AddTransient<ICreateUserUseCase, CreateUserUseCase>()
                    .AddTransient<IDeleteUserUseCase, DeleteUserUseCase>()
                    .AddTransient<IGetAllUsersUseCase, GetAllUsersUseCase>()
                    .AddTransient<IGetUserByIdUseCase, GetUserByIdUseCase>()
                    .AddTransient<IUpdateUserUseCase, UpdateUserUseCase>();
        }
    }
}
