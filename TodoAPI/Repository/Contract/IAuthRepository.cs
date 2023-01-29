using Microsoft.AspNetCore.Identity;
using TodoAPI.DTO;

namespace TodoAPI.Repository.Contract
{
    public interface IAuthRepository
    {
        Task<IEnumerable<IdentityError>> Register(UserDto user);
        Task<LoginResponseDTO> Login(UserDto user);
        Task<string> CreateRefreshToken();
        Task<LoginResponseDTO> VerifyRefreshToken(LoginResponseDTO request);
    }
}
