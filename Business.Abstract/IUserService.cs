using System.Threading.Tasks;
using Business.Models;
using Microsoft.AspNetCore.Identity;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IdentityResult> Register(UserRegistrationModel model);
        
        Task<SignInResult> Login(UserLoginModel model);

        Task SignOut();
    }
}