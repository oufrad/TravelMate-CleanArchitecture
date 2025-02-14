namespace TravelMate.Domain.User;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string UserName { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string? ProfilePicture { get; private set; } = string.Empty;
    public string? Bio { get; private set; } = string.Empty;
    public float Rating { get; private set; } = 0;

    public UserRole Role { get; private set; }
    public UserStatus Status { get; private set; }

    //public List<User> Followers { get; set; } = new List<User>();
    //public List<User> Following { get; set; } = new List<User>();
    //public List<Post> Posts { get; set; } = new List<Post>();

    public User(string name, string email, string userName, float rating, UserRole role)
    {
        Name = name;
        Email = email;
        UserName = userName;
        Rating = rating;
        Role = role;
        Status = UserStatus.Active;
    }

    public void UpdateProfile(string name, string? bio)
    {
        Name = name;
        Bio = bio ?? Bio;  // Only update if new value provided
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrEmpty(newEmail))
            throw new Exception("Email cannot be empty");

        // Add email validation logic here
        Email = newEmail;
    }

    public void UpdateUsername(string newUsername)
    {
        if (string.IsNullOrEmpty(newUsername))
            throw new Exception("Username cannot be empty");

        UserName = newUsername;
    }

    private User()
    {

    }
}