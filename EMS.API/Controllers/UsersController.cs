using EMS.Application.DTOs.User;
using EMS.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers;
[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(
        IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult>
        Create(CreateUserDto dto)
    {
        var result =
            await _userService.CreateUserAsync(dto);

        return Ok(result);
    }
}