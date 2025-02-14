using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Commands.GetAllUsers;

public record GetAllUsersQuery() : IRequest<List<User>>;
