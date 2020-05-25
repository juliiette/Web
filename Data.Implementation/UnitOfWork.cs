using System;
using Data.Abstract;
using Data.Entities;

namespace Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OfficeContext _context;
        
        public IRepository<OfficeEntity> OfficeRepository { get; }
        
        public IRepository<FirmEntity> FirmRepository { get; }
        
        public IRepository<EmployeeEntity> EmployeeRepository { get; }

        
        
        public UnitOfWork(IRepository<OfficeEntity> officeRepository,
            IRepository<FirmEntity> firmRepository,
            IRepository<EmployeeEntity> employeeRepository, OfficeContext context)
        {
            OfficeRepository = officeRepository;

            FirmRepository = firmRepository;

            EmployeeRepository = employeeRepository;

            _context = context;
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}