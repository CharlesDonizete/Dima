using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Data.Mappings.Identity;

public class IdentityRoleMapping : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.ToTable("IdentityRole");
        builder.HasKey(r => r.Id);
        builder.HasIndex(r => r.NormalizedName).IsUnique();
        builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();
        builder.Property(r => r.Name).HasMaxLength(256);
        builder.Property(r => r.NormalizedName).HasMaxLength(256);
    }
}
