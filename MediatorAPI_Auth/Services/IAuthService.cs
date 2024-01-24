using MediatorAPI_Auth.Dto_s;
using MediatorAPI_Auth.Models;

namespace MediatorAPI_Auth.Services;

public interface IAuthService
{
    Task<User> Register(UserDto userDto);
    Task<string> Login(UserDto userDto);
    Task<List<User>> GetAllUsers();
}
