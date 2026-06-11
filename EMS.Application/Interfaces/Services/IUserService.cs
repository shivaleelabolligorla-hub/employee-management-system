using EMS.Application.DTOs.User;

namespace EMS.Application.Interfaces.Services;

public interface IUserService
{
    Task<UserResponseDto> CreateUserAsync(
        CreateUserDto dto);
}