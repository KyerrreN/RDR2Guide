using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole
                {
                    Id = "4b9d4e0f-e217-4cb8-9dfc-98615530aeb7",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "8273b272-fb26-42a0-ba3f-0a7117b8f674",
                    Name = "Editor",
                    NormalizedName = "EDITOR"
                }
            );
        }
    }
}
