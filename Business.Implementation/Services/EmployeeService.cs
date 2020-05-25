using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;
using Business.Abstract;
using Data.Abstract;
using AutoMapper;
using Data.Entities;

namespace Business.Implementation.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unit;

        public EmployeeService(IMapper mapper, IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        

        public IEnumerable<EmployeeModel> GetAll()
        {
            var employees = _unit.EmployeeRepository.GetAll();

            return _mapper.Map<IEnumerable<EmployeeModel>>(employees);
        }

        
        public IEnumerable<EmployeeModel> FindByName(string name)
        {
            var employeesNames = _unit.EmployeeRepository.GetAll().Where(e => e.Name.Equals(name));

            return _mapper.Map<IEnumerable<EmployeeModel>>(employeesNames);
        }
        

        public IEnumerable<EmployeeModel> FindByDateOfBirth(DateTime dateOfBirth)
        {
            var employeesDOB = _unit.EmployeeRepository.GetAll().Where(e => e.DateOfBirth.Equals(dateOfBirth));
            
            return _mapper.Map<IEnumerable<EmployeeModel>>(employeesDOB);

        }

        
        public IEnumerable<EmployeeModel> FindByDetachment(string detachment)
        {
            var employeesDetachment = _unit.EmployeeRepository.GetAll().Where(e => e.Detachment.Equals(detachment));

            return _mapper.Map<IEnumerable<EmployeeModel>>(employeesDetachment);
        }

        
        public IEnumerable<EmployeeModel> FindByEmploymentDate(DateTime dateOfEmployment)
        {
            var employeesRecruitDate =
                _unit.EmployeeRepository.GetAll().Where(e => e.DateOfEmployment.Equals(dateOfEmployment));

            return _mapper.Map<IEnumerable<EmployeeModel>>(employeesRecruitDate);
        }

        
        public void Recruit(EmployeeModel employee, FirmModel firm, string detachment)
        {
            employee.Firm = firm;
            employee.DateOfEmployment = DateTime.Now;
            employee.Detachment = detachment;

            var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
            
            _unit.EmployeeRepository.Update(employeeEntity);
            _unit.Save();
        }

        
        public bool CheckEmployeeAttachment(EmployeeModel employee, FirmModel firm)
        {
            bool attachment = false;
            var firmEntity = _mapper.Map<FirmEntity>(firm);
            var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
            
            if (employeeEntity.Firm == firmEntity)
            {
                attachment = true;
            }

            return attachment;
        }

        public void Create(EmployeeModel employeeModel)
        {
            var employeeEntity = _mapper.Map<EmployeeEntity>(employeeModel);
            
            _unit.EmployeeRepository.Create(employeeEntity);
            _unit.Save();
        }

        public void Delete(EmployeeModel employeeModel)
        {
            var employeeEntity = _mapper.Map<EmployeeEntity>(employeeModel);
            
            _unit.EmployeeRepository.Delete(employeeEntity);
            _unit.Save();
        }
        
    }
}