using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Commands.GetAllUsers;

public class GetAllUsersQueryCommand : IRequestHandler<GetAllUsersCommand, List<User>>
{
    private readonly IUserRepository _userRepository;
    public GetAllUsersQueryCommand(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<List<User>> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllUsers();
        //return Task.FromResult(new List<string> { "User 1", "User 2" });
    }
}
