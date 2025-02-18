using Ardalis.SmartEnum;

namespace TravelMate.Domain.User;
public class UserStatus : SmartEnum<UserStatus>
{
    public static UserStatus Active = new(nameof(Active), 0);
    public static UserStatus Inactive = new(nameof(Inactive), 1);
    public static UserStatus Suspended = new(nameof(Suspended), 3);
    public static UserStatus Deleted = new(nameof(Deleted), 4);
    public UserStatus(string name, int value) : base(name, value)
    {
    }
}