using AutoMapper;
using Business.Models;
using Data.Entities;

namespace Business.Implementation.Automapper
{
    public class MyAutomapper : Profile
    {
        public MyAutomapper()
        {
            CreateMap<OfficeEntity, OfficeModel>().ReverseMap();

            CreateMap<FirmEntity, FirmModel>().ReverseMap();

            CreateMap<EmployeeEntity, EmployeeModel>().ReverseMap();

            CreateMap<UserRegistrationModel, User>().ForMember(u => u.UserName, 
                opt => opt.MapFrom(x => x.Email));
        }
    }
}