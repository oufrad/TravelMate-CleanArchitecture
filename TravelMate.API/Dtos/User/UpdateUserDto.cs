namespace TravelMate.Api.Dtos.User;

public record UpdateUserDto(int Id, string name, string email, UserRole role, UserStatus status);

