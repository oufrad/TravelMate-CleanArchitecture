using MediatR;
using TravelMate.Domain.Entities;

namespace TravelMate.Application.Features.Users.Commands.GetAllUsers;

public record GetAllUsersQuery() : IRequest<List<User>>;
