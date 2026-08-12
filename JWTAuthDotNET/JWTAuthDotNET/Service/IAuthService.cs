using JWTAuthDotNET.Entities;
using JWTAuthDotNET.Models;

namespace JWTAuthDotNET.Service
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<string?> LoginAsync(UserDTO request);
    }
}
