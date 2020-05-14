using Data.Abstract;
using Data.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Implementation
{
    public static class DataServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OfficeContext>();
            
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}