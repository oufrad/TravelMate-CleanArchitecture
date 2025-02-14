using AutoMapper;
using TravelMate.Api.Dtos.User;
using TravelMate.Application.Features.Users.Queries.AddUser;

namespace TravelMate.Api.Mappers;

public class PresentationMappingProfile: Profile
{
    public PresentationMappingProfile()
    {
        // Presentation -> Application mappings
        CreateMap<SimplifiedUserDto, AddUserQuery>();
    }
}
