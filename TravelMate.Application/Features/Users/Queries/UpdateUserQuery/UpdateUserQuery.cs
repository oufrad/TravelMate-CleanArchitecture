using MediatR;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.UpdateUserQuery;

public record UpdateUserQuery(int Id, string name, string email, UserRole role, UserStatus status) : IRequest<User>;
