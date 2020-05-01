using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Models;
using Business.Abstract;
using AutoMapper;

namespace Business.Implementation.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<EmployeeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> FindByDateOfBirth(DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> FindByDetachment(string detachment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> FindByEmploymentDate(DateTime dateOfEmployment)
        {
            throw new NotImplementedException();
        }

        public Task Recruit(EmployeeModel employee, FirmModel firm, DateTime date, string detachment)
        {
            throw new NotImplementedException();
        }

        public Task CheckEmployeeAttachment(EmployeeModel employee, FirmModel firm)
        {
            throw new NotImplementedException();
        }
    }
}