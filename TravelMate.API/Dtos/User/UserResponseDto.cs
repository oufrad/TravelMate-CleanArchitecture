using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelMate.Api.Dtos.User;

public record UserResponseDto
{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? ProfilePicture { get; set; } = string.Empty;
        public string? Bio { get; set; } = string.Empty;
        public float Rating { get; set; } = 0;
}
