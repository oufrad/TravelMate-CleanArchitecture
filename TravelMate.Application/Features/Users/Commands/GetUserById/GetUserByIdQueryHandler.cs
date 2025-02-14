using MediatR;
using TravelMate.Application.Common.Interfaces;
using TravelMate.Domain.Entities;

namespace TravelMate.Application.Features.Users.Commands.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }  
        
        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetById(request.Id);
        }
    }
}
