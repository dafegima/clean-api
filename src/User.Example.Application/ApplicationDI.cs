using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;
using User.Example.Application.Commands.CreateUser;
using User.Example.Application.PipelineBehaviors;

namespace User.Example.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssemblies(new List<Assembly>() { typeof(CreateUserCommandValidator).Assembly });
            return services;
        }
    }
}
