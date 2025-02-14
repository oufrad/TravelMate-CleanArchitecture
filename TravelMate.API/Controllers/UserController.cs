using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.User;
using TravelMate.Application.Features.Users.Commands.GetAllUsers;
using TravelMate.Application.Features.Users.Commands.GetUserById;
using TravelMate.Application.Features.Users.Queries.AddUser;

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
        var addUserQuery = new AddUserCommand(ProfilePicture : user.ProfilePicture, Rating : user.Rating, UserName : user.UserName);
        var resultUser = await _mediator.Send(addUserQuery);
        return Ok(resultUser);
    }
}
