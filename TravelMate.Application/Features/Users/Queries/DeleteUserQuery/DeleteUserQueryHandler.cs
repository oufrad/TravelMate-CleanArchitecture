using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.DeleteUserQuery;

public class DeleteUserQueryHandler : IRequestHandler<DeleteUserQuery, User>
{
    private readonly IUserRepository _userRepository;
    public DeleteUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<User> Handle(DeleteUserQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.DeleteUserAsync(request.Id);
    }
}
