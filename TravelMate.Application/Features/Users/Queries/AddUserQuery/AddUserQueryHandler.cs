using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.AddUser;

public class AddUserQueryHandler : IRequestHandler<AddUserQuery, User>
{
    private readonly IUserRepository _userRepository;

    public AddUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<User> Handle(AddUserQuery request, CancellationToken cancellationToken)
    {
        User user = new User(request.name, request.email, request.role);
        User resutUser = await _userRepository.AddUser(user);
        return resutUser;
    }
}
