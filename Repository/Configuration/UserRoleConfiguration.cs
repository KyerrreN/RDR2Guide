using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
            (
                new IdentityUserRole<string>
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    RoleId = "4b9d4e0f-e217-4cb8-9dfc-98615530aeb7",
                },
                new IdentityUserRole<string>
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RoleId = "4b9d4e0f-e217-4cb8-9dfc-98615530aeb7",
                },
                new IdentityUserRole<string>
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    RoleId = "4b9d4e0f-e217-4cb8-9dfc-98615530aeb7",
                }
            );
        }
    }
}
