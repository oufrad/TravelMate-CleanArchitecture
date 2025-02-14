using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
{
    private readonly IUserRepository _userRepository;

    public AddUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        User user = new User(request.name, request.email, request.UserName, request.Rating, request.role);
        User resutUser = await _userRepository.AddUser(user);
        return resutUser;
    }
}
