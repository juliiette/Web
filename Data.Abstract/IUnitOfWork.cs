using System.Threading.Tasks;
using Data.Entities;

namespace Data.Abstract
{
    public interface IUnitOfWork
    {
        IGenericRepository<EmployeeEntity> EmployeeRepository { get; }

        IGenericRepository<FirmEntity> FirmRepository { get; }

        IGenericRepository<OfficeEntity> OfficeRepository { get; }
        
        void Save();
    }
}