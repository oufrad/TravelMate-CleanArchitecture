namespace TravelMate.Domain.User;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string? UserName { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string? ProfilePicture { get; private set; } = string.Empty;
    public string? Bio { get; private set; } = string.Empty;
    public float? Rating { get; private set; }

    public UserRole Role { get; private set; }
    public UserStatus Status { get; private set; }

    //public List<User> Followers { get; set; } = new List<User>();
    //public List<User> Following { get; set; } = new List<User>();
    //public List<Post> Posts { get; set; } = new List<Post>();

    public User(string name, string email, UserRole role)
    {
        Name = name;
        Email = email;
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

    public void UpdateName(string newName)
    {
        if (string.IsNullOrEmpty(newName))
            throw new Exception("Name cannot be empty");

        // Add email validation logic here
        Name = newName;
    }


    public void UpdateUsername(string newUsername)
    {
        if (string.IsNullOrEmpty(newUsername))
            throw new Exception("Username cannot be empty");

        UserName = newUsername;
    }

    public void UpdateRole(UserRole newRole)
    {
        if (newRole is null) throw new ArgumentNullException(nameof(newRole));

        if (UserRole.FromValue(newRole.Value) is null)
            throw new Exception("Invalid role");

        Role = newRole;
    }

    public void UpdateStatus(UserStatus newStatus)
    {
        if (newStatus is null)
            throw new ArgumentNullException(nameof(newStatus));

        if (!UserStatus.TryFromName(newStatus.Name, out _))
            throw new Exception("Invalid status");

        Status = newStatus;
    }




    private User()
    {

    }
}