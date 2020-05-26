using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Implementation.Automapper;
using Business.Implementation.Services;
using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Business.Implementation
{
    public static class BusinessServices
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IFirmService, FirmService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserService, UserService>();
            services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();

            var mapperConfig = new MapperConfiguration(c => c.AddProfile(new MyAutomapper()));

            var mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}