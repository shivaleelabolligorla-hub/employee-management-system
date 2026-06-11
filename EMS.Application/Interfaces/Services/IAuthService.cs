using EMS.Application.DTOs.Authentication;

namespace EMS.Application.Interfaces.Services;

public interface IAuthService
{
    Task<LoginResponseDto>
        LoginAsync(LoginRequestDto dto);
}