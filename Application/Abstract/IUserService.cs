using Application.Models;
using Domain.Entities;

namespace Application.Abstract
{
    public interface IUserService
    {
        Task<WebApiResponse> Authenticate(UserLoginDto userLoginDto);
        Task<WebApiResponse> Register(UserDto user);
        Task<WebApiResponse> ChangePassword(ChangePasswordModelDto changePasswordModel);
        Task<Users> GetUserById(int id);
    }
}
