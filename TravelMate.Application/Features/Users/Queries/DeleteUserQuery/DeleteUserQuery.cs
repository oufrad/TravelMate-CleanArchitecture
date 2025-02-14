using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.DeleteUserQuery
{
    public record DeleteUserQuery(string Id) : IRequest<User>;

}
