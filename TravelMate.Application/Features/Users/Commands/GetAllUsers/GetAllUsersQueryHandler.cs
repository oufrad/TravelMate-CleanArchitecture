using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.Entities;

namespace TravelMate.Application.Features.Users.Commands.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;
    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllUsers();
        //return Task.FromResult(new List<string> { "User 1", "User 2" });
    }
}
