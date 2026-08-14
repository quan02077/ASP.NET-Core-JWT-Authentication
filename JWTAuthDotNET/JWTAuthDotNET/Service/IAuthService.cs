using JWTAuthDotNET.Entities;
using JWTAuthDotNET.Models;

namespace JWTAuthDotNET.Service
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);
        Task<TokenReponseDto?> LoginAsync(UserDTO request);
        Task<TokenReponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}
