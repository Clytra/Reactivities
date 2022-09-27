using Application.Activties;
using Application.Core;
using Application.Interfaces;
using Infrastructure.Security;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            // TODO: TermsOfService + License
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Reactivities",
                    Version = "v1",
                    TermsOfService = new Uri(""),
                    Contact = new OpenApiContact
                    {
                        Name = "Karolina",
                        Email = "karolina.agata.kowalska@gmail.com",
                        Url = new Uri("")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "",
                        Url = new Uri("")
                    }
                });
                var filePath = Path.Combine(AppContext.BaseDirectory, "Reactivities.xml");
                swagger.IncludeXmlComments(filePath);
            });

            services.AddHealthChecks();

            services.AddCors(options =>
                options.AddPolicy(name: "CorsPolicy",
                builder =>
                {
                    builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
                }));

            services.AddMediatR(typeof(List.Handler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddScoped<IUserAccessor, UserAccessor>();

            return services;
        }
    }
}
