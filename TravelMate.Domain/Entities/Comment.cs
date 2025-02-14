namespace TravelMate.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CommentedOn { get; set; } = DateTime.Now;

    public int PostId { get; set; }
    public Post Post { get; set; } = null!;

    //public int UserId { get; set; }
    //public User User { get; set; } = null!;
}
