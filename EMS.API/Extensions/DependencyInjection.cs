using EMS.Application.Interfaces.Repositories;
using EMS.Application.Interfaces.Services;
using EMS.Application.Services;


using EMS.Infrastructure.Services;
using EMS.Persistence.Repositories;

namespace EMS.API.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection
        AddProjectServices(
            this IServiceCollection services)
    {
        services.AddScoped<
            IUserRepository,
            UserRepository>();
        services.AddScoped<
            IRoleRepository,
            RoleRepository>();
        services.AddScoped<
            IJwtService,
            JwtService>();
        services.AddScoped<
            IUserService,
            UserService>();
        services.AddScoped<
        IAuthService,
        AuthService>();

        return services;
    }
}