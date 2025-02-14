namespace TravelMate.Api.Dtos.Post;

public record PostResponseDto
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string? Location { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public int? Likes { get; set; } = 0;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}
