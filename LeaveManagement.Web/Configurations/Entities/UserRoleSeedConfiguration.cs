using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "f7dd3d04-0b88-4959-b277-57110d40bf56",
                    UserId = "e7ee3d04-0f61-3662-b249-57110f40fc56"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a9bc3h04-0b88-4959-f144-57430d36bb56",
                    UserId = "c4aa3d07-0c88-3332-d24d-57110f40fc56"
                }
                );
        }
    }
}