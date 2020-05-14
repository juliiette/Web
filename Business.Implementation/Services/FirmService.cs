using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models;
using Data.Abstract;
using Data.Entities;

namespace Business.Implementation.Services
{
    public class FirmService : IFirmService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;

        public FirmService(IMapper mapper, IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }
        

        public IEnumerable<FirmModel> GetAll()
        {
            var firms = _unit.FirmRepository.GetAll();

            return _mapper.Map<IEnumerable<FirmModel>>(firms);
        }

        public IEnumerable<FirmModel> FindByDepartment(string department)
        {
            var firmByDepartment = _unit.FirmRepository.GetAll().Where(f => f.Department.Equals(department));

            return _mapper.Map<IEnumerable<FirmModel>>(firmByDepartment);
        }

        public IEnumerable<FirmModel> FindByCreationDate(DateTime dateOfCreation)
        {
            var firmByDate = _unit.FirmRepository.GetAll().Where(f => f.CreationDate.Equals(dateOfCreation));

            return _mapper.Map<IEnumerable<FirmModel>>(firmByDate);
        }

        public IEnumerable<FirmModel> FindByEmployeesQuantity(int quantityOfEmployees)
        {
            var firmByEmployees =
                _unit.FirmRepository.GetAll().Where(f => f.WorkersQuantity.Equals(quantityOfEmployees));

            return _mapper.Map<IEnumerable<FirmModel>>(firmByEmployees);
        }

        public void AddDetachment(string detachment, FirmModel firm)
        {
            firm.Detachments.Add(detachment);
            
            var firmEntity = _mapper.Map<FirmEntity>(firm);
            
            _unit.FirmRepository.Update(firmEntity);
            _unit.Save();
        }
    }
}