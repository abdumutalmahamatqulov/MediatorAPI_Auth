using MediatorAPI_Auth.Dto_s;
using MediatorAPI_Auth.ExtensionFunctions;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MediatorAPI_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly UserManager<User> _userManager;

    public AuthController(IAuthService authService, UserManager<User> userManager)
    {
        _userManager = userManager;
        _authService = authService;
    }

    [HttpGet, Authorize]
    public ActionResult<string> GetMyName() => Ok(CreateTokenInJwtAuthorizationFromUsers.GetMyId());

    [HttpGet("ListUsers"), Authorize]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await _authService.GetAllUsers());
    }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserDto request) => Ok(await _authService.Register(request));

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserDto request) => Ok(await _authService.Login(request));
}
