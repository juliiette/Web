using System.Threading.Tasks;
using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Data.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<EmployeeEntity> EmployeeRepository { get; }

        IRepository<FirmEntity> FirmRepository { get; }

        IRepository<OfficeEntity> OfficeRepository { get; }
        
        UserManager<User> UserManager { get; }
        
        SignInManager<User> SignInManager { get; }
        
        void Save();
    }
}