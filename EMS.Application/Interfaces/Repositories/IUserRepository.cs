using EMS.Domain.Entities;

namespace EMS.Application.Interfaces.Repositories;

public interface IUserRepository
    : IGenericRepository<User>
{
    Task<User?> GetByUsernameAsync(string username);
}