using System.Threading.Tasks;
using Data.Entities;

namespace Data.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<EmployeeEntity> EmployeeRepository { get; }

        IRepository<FirmEntity> FirmRepository { get; }

        IRepository<OfficeEntity> OfficeRepository { get; }
        
        void Save();
    }
}