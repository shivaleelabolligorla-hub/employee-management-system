using EMS.API.Middleware;

namespace EMS.API.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder
        UseGlobalExceptionMiddleware(
            this IApplicationBuilder app)
    {
        return app.UseMiddleware<
            GlobalExceptionMiddleware>();
    }
}