using System;
using Data.Abstract;
using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OfficeContext _context;
        
        public IRepository<OfficeEntity> OfficeRepository { get; }
        
        public IRepository<FirmEntity> FirmRepository { get; }
        
        public IRepository<EmployeeEntity> EmployeeRepository { get; }
        
        public UserManager<User> UserManager { get; }
        
        public SignInManager<User> SignInManager { get; }

        public UnitOfWork(IRepository<OfficeEntity> officeRepository,
            IRepository<FirmEntity> firmRepository,
            IRepository<EmployeeEntity> employeeRepository, OfficeContext context,
            UserManager<User> userManager, SignInManager<User> signInManager)
        {
            OfficeRepository = officeRepository;

            FirmRepository = firmRepository;

            EmployeeRepository = employeeRepository;

            _context = context;
            
            UserManager = userManager;
            
            SignInManager = signInManager;
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}