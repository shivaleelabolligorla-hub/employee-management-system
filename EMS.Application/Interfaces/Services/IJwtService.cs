using EMS.Domain.Entities;

namespace EMS.Application.Interfaces.Services;

public interface IJwtService
{
    string GenerateToken(User user);
}