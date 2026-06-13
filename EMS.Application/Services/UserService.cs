using EMS.Application.DTOs.User;
using EMS.Application.Interfaces.Repositories;
using EMS.Application.Interfaces.Services;
using EMS.Domain.Entities;

namespace EMS.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IRoleRepository _roleRepository;

    public UserService(
        IUserRepository userRepository,
        IRoleRepository roleRepository)
    {
        _userRepository = userRepository;
        _roleRepository = roleRepository;
    }

    public async Task<UserResponseDto>
        CreateUserAsync(CreateUserDto dto)
    {
        var role =
            await _roleRepository
                .GetByIdAsync(dto.RoleId);

        if (role == null)
        {
            throw new Exception("Invalid Role");
        }

        var user = new User
        {
            Username = dto.Username,
            Email = dto.Email,

            PasswordHash =
                BCrypt.Net.BCrypt.HashPassword(
                    dto.Password),

            RoleId = dto.RoleId,

            CreatedDate = DateTime.UtcNow,

            IsActive = true
        };

        await _userRepository.AddAsync(user);

        await _userRepository.SaveChangesAsync();

        return new UserResponseDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            RoleName = role.RoleName
        };
    }
}