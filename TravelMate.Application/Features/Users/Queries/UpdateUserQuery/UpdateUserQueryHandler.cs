using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.User;

namespace TravelMate.Application.Features.Users.Queries.UpdateUserQuery
{
    public class UpdateUserQueryHandler : IRequestHandler<UpdateUserQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public UpdateUserQueryHandler(IUserRepository userRepository) 
        {
            _userRepository = userRepository;  
        }
        public async Task<User> Handle(UpdateUserQuery request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetById(request.Id);
            user.UpdateEmail(request.email);
            user.UpdateName(request.name);
            user.UpdateRole(request.role);
            user.UpdateStatus(request.status);
            return await _userRepository.UpdateUserAsync(user);
        }
    }
}
