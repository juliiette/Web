using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Implementation
{
    public class OfficeContext : DbContext
    {
        public OfficeContext(DbContextOptions<OfficeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<EmployeeEntity> Employees { get; set; }

        public DbSet<FirmEntity> Firms { get; set; }

        public DbSet<OfficeEntity> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            #region Data
            
            model.Entity<EmployeeEntity>().ToTable("Employees");
            model.Entity<EmployeeEntity>().HasData(

                new EmployeeEntity
                {
                    Id = 1,
                    Name = "Пупкин Вася",
                    DateOfBirth = new DateTime(1998, 09, 22),
                    Detachment = "Сисадминное царство",
                    DateOfEmployment = new DateTime(2020, 03, 08),
                    FirmId = 1,
                    Firm = Firms.Find(1)
                },
                new EmployeeEntity
                {
                    Id = 2,
                    Name = "Королевна Катя",
                    DateOfBirth = new DateTime(1999, 10, 2),
                    Detachment = "Бухгалтерия",
                    DateOfEmployment = new DateTime(2020, 04, 08),
                    FirmId = 2,
                    Firm = Firms.Find(2)
                },
                new EmployeeEntity
                {
                    Id = 3,
                    Name = "Программистка Лиза",
                    DateOfBirth = new DateTime(1997, 3, 3),
                    Detachment = "Сисадминное царство",
                    DateOfEmployment = new DateTime(2020, 03, 08),
                    FirmId = 1,
                    Firm = Firms.Find(1)
                }
            );

            model.Entity<FirmEntity>().ToTable("Firms");
            model.Entity<FirmEntity>().HasData(
                new FirmEntity
                {
                    Id = 1,
                    Name = "KPI",
                    CreationDate = new DateTime(2018, 12, 31),
                    Department = "Univer",
                    WorkersQuantity = 20,
                    Detachments = new List<string>() {"Бухгалтерия", "Сисадминное царство"}
                },
                new FirmEntity
                {
                    Id = 2,
                    Name = "OOO Sharaga",
                    CreationDate = new DateTime(2018, 3, 8),
                    Department = "Univer",
                    WorkersQuantity = 432,
                    Detachments = new List<string>() {"Бухгалтерия"}
                });

            model.Entity<OfficeEntity>().ToTable("Offices");
            model.Entity<OfficeEntity>().HasData(
                new OfficeEntity
                {
                    Id = 1,
                    Name = "Ну шо за офис",
                    FirmId = 1,
                    Firm = Firms.Find(1)
                });
            #endregion
        }
    }
}