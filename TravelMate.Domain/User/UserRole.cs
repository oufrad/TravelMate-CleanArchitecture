using Ardalis.SmartEnum;

namespace TravelMate.Domain.User;

public class UserRole : SmartEnum<UserRole>
{
    public static UserRole Regular = new(nameof(Regular), 0);
    public static UserRole Admin = new(nameof(Admin), 1);
    public static UserRole Moderator = new(nameof(Moderator), 3);
    public UserRole(string name, int value) : base(name, value)
    {
    }
}
