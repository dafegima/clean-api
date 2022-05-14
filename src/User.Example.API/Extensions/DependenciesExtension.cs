using User.Example.API.Endpoints.User;
using User.Example.Application.Commands.UserCmd;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace User.Example.API.Extensions
{
    public static class DependenciesExtension
    {
        /// <summary>
        /// Add Controllers configuration
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddControllersConfiguration(this IServiceCollection services)
        {
            services.AddResponseCompression().AddControllers();//.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserCommandValidator>());


            return services;
        }

        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            return services.AddMediatR(typeof(CreateUserCommand).Assembly);
        }

        public static IServiceCollection RegisterCors(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            return services;
        }
    }
}