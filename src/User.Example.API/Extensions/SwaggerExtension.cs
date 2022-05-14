using User.Example.API.Endpoints.User;
using User.Example.API.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace User.Example.API.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection RegisterSwagger(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddApiVersioning(
               options =>
               {
                   options.ReportApiVersions = true;
               });
            services.AddVersionedApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;
                });

            services.AddSwaggerGen(
               options =>
               {
                   options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                   {
                       Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                       Name = "Authorization",
                       In = ParameterLocation.Header,
                       Type = SecuritySchemeType.ApiKey,
                       Scheme = "Bearer"
                   });

                   options.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                           {   new OpenApiSecurityScheme {
                                   Reference = new OpenApiReference {
                                       Type = ReferenceType.SecurityScheme,
                                       Id = "Bearer"
                                   },
                                   Scheme = "token",
                                   Name = "Bearer",
                                   In = ParameterLocation.Header
                               },
                               new List<string>()
                           }
                       });

                   // add a custom operation filter which sets default values
                   options.OperationFilter<SwaggerDefaultValues>();

                   // integrate xml comments
                   options.IncludeXmlComments(XmlCommentsFilePath);
               });

            return services;
        }

        private static string XmlCommentsFilePath
        {
            get
            {
                var basePath = AppContext.BaseDirectory;
                var fileName = typeof(CreateUserEndpoint).GetTypeInfo().Assembly.GetName().Name + ".xml";

                return Path.Combine(basePath, fileName);
            }
        }

    }
}
