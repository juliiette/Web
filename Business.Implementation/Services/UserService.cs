using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models;
using Data.Abstract;
using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Business.Implementation.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUnitOfWork unit)
        {
            _mapper = mapper;
            _unit = unit;
        }

        public async Task<IdentityResult> Register(UserRegistrationModel model)
        {
            var user = _mapper.Map<User>(model);
            var result = await _unit.UserManager.CreateAsync(user, model.Password);

            return result;
        }

        public async Task<SignInResult> Login(UserLoginModel model)
        {
            var result = await _unit.SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            return result;
        }

        public async Task SignOut()
        {
            await _unit.SignInManager.SignOutAsync();
        }
    }
}