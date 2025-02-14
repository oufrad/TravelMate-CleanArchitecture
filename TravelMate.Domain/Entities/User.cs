using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelMate.Domain.Entities;

public partial class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? ProfilePicture { get; set; } = string.Empty;
    public string? Bio { get; set; } = string.Empty;
    public float Rating { get; set; } = 0;

    //public List<User> Followers { get; set; } = new List<User>();
    //public List<User> Following { get; set; } = new List<User>();
    //public List<Post> Posts { get; set; } = new List<Post>();
}