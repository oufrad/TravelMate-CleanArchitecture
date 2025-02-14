using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.Entities;

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
        User user = new User()
        {
            UserName = request.UserName,
            Rating = request.Rating
        };
        User resutUser = await _userRepository.AddUser(user);
        return resutUser;
    }
}
