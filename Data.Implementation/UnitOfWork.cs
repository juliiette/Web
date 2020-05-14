using System;
using Data.Abstract;
using Data.Entities;

namespace Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OfficeContext _context;
        
        public IGenericRepository<OfficeEntity> OfficeRepository { get; }
        
        public IGenericRepository<FirmEntity> FirmRepository { get; }
        
        public IGenericRepository<EmployeeEntity> EmployeeRepository { get; }

        
        
        public UnitOfWork(IGenericRepository<OfficeEntity> officeRepository,
            IGenericRepository<FirmEntity> firmRepository,
            IGenericRepository<EmployeeEntity> employeeRepository, OfficeContext context)
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