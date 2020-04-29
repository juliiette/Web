using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Abstract
{
    public interface IFirmService
    {
        IEnumerable<FirmModel> GetAll();

        IEnumerable<FirmModel> FindByDepartment(string department);
        
        IEnumerable<FirmModel> FindByCreationDate(DateTime dateOfCreation);
        
        IEnumerable<FirmModel> FindByEmployeesQuantity(int quantityOfEmployees);

        Task AddDetachment(string detachment);
    }
}