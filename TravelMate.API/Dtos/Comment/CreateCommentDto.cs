namespace TravelMate.Api.Dtos.Comment;

public record CreateCommentDto(string Content, int PostId, int UserId);

