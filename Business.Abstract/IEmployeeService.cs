using Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetAll();
        
        IEnumerable<EmployeeModel> FindByName(string name);
        
        IEnumerable<EmployeeModel> FindByDateOfBirth(DateTime dateOfBirth);
        
        IEnumerable<EmployeeModel> FindByDetachment(string detachment);

        IEnumerable<EmployeeModel> FindByEmploymentDate(DateTime dateOfEmployment);

        void Recruit(EmployeeModel employee, FirmModel firm, string detachment);

        bool CheckEmployeeAttachment(EmployeeModel employee, FirmModel firm);

        void Create(EmployeeModel employeeModel);

        void Delete(int id);

    }
}