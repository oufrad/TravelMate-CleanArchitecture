using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Commands.GetUserById;

public record GetUserByIdQuery(int Id): IRequest<User>;
