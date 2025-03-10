﻿using Domain.Interfaces.AppSettings;
using Domain.Interfaces.Requests;
using Domain.InterfacesRepositories.Employees;
using Infrastructure.Repositories.Employees;
using Infrastructure.Services.AppSettings;
using Infrastructure.Services.Requests;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Common
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddTransient<IApiSettingsService, ApiSettingsService>();
            services.AddTransient<IExternalApiService, ExternalApiService>();

            return services;
        }
    }
}
