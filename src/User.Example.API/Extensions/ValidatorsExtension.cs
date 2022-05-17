using User.Example.Application.Commands.CreateUser;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using User.Example.Application.PipelineBehaviors;
using System.Reflection;
using System.Collections.Generic;

namespace User.Example.API.Extensions
{
    public static class ValidatorsExtension
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssemblies(new List<Assembly>() { typeof(CreateUserCommandValidator).Assembly});
            return services;
        }
    }
}
