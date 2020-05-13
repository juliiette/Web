using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Implementation
{
    public class OfficeContext : DbContext 
    {
        public OfficeContext(DbContextOptions<OfficeContext> options) : base()
        {
            Database.EnsureCreated();
        }


        public DbSet<EmployeeEntity> Employees { get; set; }
        
        public DbSet<FirmEntity> Firms { get; set; }

        public DbSet<OfficeEntity> Offices { get; set; }
        
        
    }
}