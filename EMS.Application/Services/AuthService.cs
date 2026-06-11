using EMS.Application.DTOs.Authentication;
using EMS.Application.Interfaces.Repositories;
using EMS.Application.Interfaces.Services;
using BCrypt.Net;

namespace EMS.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtService _jwtService;

    public AuthService(
        IUserRepository userRepository,
        IJwtService jwtService)
    {
        _userRepository = userRepository;
        _jwtService = jwtService;
    }

    public async Task<LoginResponseDto>
        LoginAsync(LoginRequestDto dto)
    {
        var user =
            await _userRepository
                .GetByUsernameAsync(dto.Username);

        if (user == null)
        {
            throw new Exception(
                "Invalid username or password");
        }

        var validPassword =
            BCrypt.Net.BCrypt.Verify(
                dto.Password,
                user.PasswordHash);

        if (!validPassword)
        {
            throw new Exception(
                "Invalid username or password");
        }

        var token =
            _jwtService.GenerateToken(user);

        return new LoginResponseDto
        {
            Token = token,
            Expiration =
                DateTime.UtcNow.AddMinutes(60)
        };
    }
}