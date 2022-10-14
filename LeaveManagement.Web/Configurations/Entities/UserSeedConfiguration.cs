using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                    new Employee
                    {
                        Id = "e7ee3d04-0f61-3662-b249-57110f40fc56",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        UserName = "admin@localhost.com",
                        FirstName = "System",
                        LastName = "Admin",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    },
                    new Employee
                    {
                        Id = "c4aa3d07-0c88-3332-d24d-57110f40fc56",
                        Email = "user@localhost.com",
                        NormalizedEmail = "USER@LOCALHOST.COM",
                        NormalizedUserName = "USER@LOCALHOST.COM",
                        UserName = "admin@localhost.com",
                        FirstName = "System",
                        LastName = "User",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    }
                    );
        }
    }
}