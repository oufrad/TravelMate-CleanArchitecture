namespace TravelMate.Domain.Post;

public class Post
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string? Location { get; set; } = string.Empty;
    public string? Image { get; set; } = string.Empty;
    public int? Likes { get; set; } = 0;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    //public List<Comment>? Comments { get; set; } = new List<Comment>();

    //public int UserId { get; set; }
    //public User User { get; set; } = null!;
}
