using Microsoft.AspNetCore.Mvc;
using ToDo.RestApi.Interfaces;

namespace ToDo.RestApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    [Route("/GetAllUsers")]
    public async Task<ActionResult<List<User>>> GetAllUsers()
    {
        try
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while retrieving users. Please try again later.");
        }
    }
}