using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMate.Domain.User;

namespace TravelMate.Infrastructure.Persistence.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .UseIdentityColumn();

        builder.Property(u => u.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(u => u.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(u => u.UserName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Rating)
            .HasDefaultValue(0f);

        builder.Property(u => u.Role)
            .HasConversion(
                userRole => userRole.Value,
                value => UserRole.FromValue(value)
            );

        builder.Property(u => u.Status)
            .HasConversion(
                userStatus => userStatus.Value,
                value => UserStatus.FromValue(value)
            );
    }
}
