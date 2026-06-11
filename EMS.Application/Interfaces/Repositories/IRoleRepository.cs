using EMS.Domain.Entities;

namespace EMS.Application.Interfaces.Repositories;

public interface IRoleRepository
{
    Task<Role?> GetByIdAsync(int id);
}