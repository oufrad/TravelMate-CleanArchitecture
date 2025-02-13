using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.User;

namespace TravelMate.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(SimplifiedUserDto user)
    {
        return Ok();
    }
}
