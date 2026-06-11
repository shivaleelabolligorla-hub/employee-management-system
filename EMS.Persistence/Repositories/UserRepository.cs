using EMS.Application.Interfaces.Repositories;
using EMS.Domain.Entities;
using EMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EMS.Persistence.Repositories;

public class UserRepository
    : GenericRepository<User>,
      IUserRepository
{
    public UserRepository(
        ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<User?> GetByUsernameAsync(
        string username)
    {
        return await _context.Users
            .Include(x => x.Role)
            .FirstOrDefaultAsync(
                x => x.Username == username);
    }
}