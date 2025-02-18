using MediatR;
using TravelMate.Application.Dtos;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.AddUser;

public record AddUserQuery(string name, string email, UserRole role) : IRequest<User>;
