using MediatR;
using TravelMate.Application.Dtos;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.AddUser;

public record AddUserCommand(string name, string UserName, string email, float Rating, UserRole role) : IRequest<User>;
