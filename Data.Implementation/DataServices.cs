using Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Implementation
{
    public static class DataServices
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OfficeContext>(options =>
                options.UseSqlServer(connectionString));
            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}