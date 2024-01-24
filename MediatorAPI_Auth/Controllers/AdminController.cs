using MediatorAPI_Auth.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatorAPI_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly AppDbContext _context;

    public AdminController(AppDbContext context) 
        => _context = context;
    [HttpGet]
    public async Task<IActionResult> GetAll() 
        => Ok(await _context.Users.ToListAsync());
}
