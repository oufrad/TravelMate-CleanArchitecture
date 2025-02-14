using MediatR;
using TravelMate.Application.Dtos;
using TravelMate.Domain.Entities;

namespace TravelMate.Application.Features.Users.Queries.AddUser;

public record AddUserCommand(string UserName, string? ProfilePicture, float Rating) : IRequest<User>;
