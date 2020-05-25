using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Implementation.Automapper;
using Business.Implementation.Services;

namespace Business.Implementation
{
    public static class BusinessServices
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IFirmService, FirmService>();

            var mapperConfig = new MapperConfiguration(c => c.AddProfile(new MyAutomapper()));

            var mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}