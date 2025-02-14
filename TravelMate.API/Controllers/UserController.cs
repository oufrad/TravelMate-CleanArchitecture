using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.User;
using TravelMate.Application.Features.Users.Commands.GetAllUsers;
using TravelMate.Application.Features.Users.Commands.GetUserById;
using TravelMate.Application.Features.Users.Queries.AddUser;
using TravelMate.Application.Features.Users.Queries.DeleteUserQuery;
using TravelMate.Application.Features.Users.Queries.UpdateUserQuery;
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
        var users = await _mediator.Send(new GetAllUsersCommand());
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
        var addUserQuery = new AddUserQuery(user.name, user.UserName, user.email, user.Rating, role);
        var resultUser = await _mediator.Send(addUserQuery);
        return Ok(resultUser);
    }

    [HttpPut]
    public async Task<ActionResult<UserResponseDto>> UpdateUser(UpdateUserDto user)
    {
        var updatedUser = await _mediator.Send(new UpdateUserQuery(Id: user.Id, name: user.name, UserName: user.UserName, email: user.email, bio: user.bio ));
        return Ok(updatedUser);
    }

    [HttpDelete]
    public async Task<ActionResult<UserResponseDto>> DeleteUser(string Id)
    {
        var deletedUser = await _mediator.Send(new DeleteUserQuery(Id: Id));
        return Ok(deletedUser);
    }
}
