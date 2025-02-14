using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.User;
using TravelMate.Application.Features.Users.Commands.GetAllUsers;
using TravelMate.Application.Features.Users.Commands.GetUserById;
using TravelMate.Application.Features.Users.Queries.AddUser;

using UserRole = TravelMate.Domain.User.UserRole;

namespace TravelMate.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly ISender _mediator;
    public UserController(ISender mediator) 
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<List<UserResponseDto>>> GetAllUsers()
    {
        var users = await _mediator.Send(new GetAllUsersQuery());
        //TODO: Map the Users into UserResponseDtos
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserResponseDto>> GetUserById([FromRoute] int id)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(Id: id));
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<UserResponseDto>> AddUser(SimplifiedUserDto user)
    {
        if (!UserRole.TryFromName(user.role.ToString(), out UserRole role)) 
        {
            return Problem(
                detail : "Invalid Role Type"
                );
        }
        var addUserQuery = new AddUserCommand(user.name, user.UserName, user.email, user.Rating, role);
        var resultUser = await _mediator.Send(addUserQuery);
        return Ok(resultUser);
    }
}
