using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.UpdateUserQuery;

public record UpdateUserQuery(int Id, string name, string UserName, string email, string bio) : IRequest<User>;
