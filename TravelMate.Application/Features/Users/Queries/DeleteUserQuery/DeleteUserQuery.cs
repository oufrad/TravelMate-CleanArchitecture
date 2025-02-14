using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.DeleteUserQuery
{
    public record DeleteUserQuery(int Id) : IRequest<User>;

}
