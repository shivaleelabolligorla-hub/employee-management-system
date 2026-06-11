using EMS.Application.Interfaces.Repositories;
using EMS.Domain.Entities;
using EMS.Persistence.Context;

namespace EMS.Persistence.Repositories;

public class RoleRepository
    : GenericRepository<Role>,
      IRoleRepository
{
    public RoleRepository(
        ApplicationDbContext context)
        : base(context)
    {
    }
}