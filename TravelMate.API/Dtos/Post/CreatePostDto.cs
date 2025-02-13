namespace TravelMate.Api.Dtos.Post;

public record CreatePostDto(string Content, string? Location, string? Image, int UserId);
