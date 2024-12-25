using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignInSignUpUsingIdentity.Areas.Identity.Data;

namespace SignInSignUpUsingIdentity.Areas.Identity.Data;

public class DbContextSample : IdentityDbContext<SignInSignUpUsingIdentityUser>
{
    public DbContextSample(DbContextOptions<DbContextSample> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<SignInSignUpUsingIdentityUser>
{
    public void Configure(EntityTypeBuilder<SignInSignUpUsingIdentityUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
        builder.Property(x => x.Phone).HasMaxLength(10);
    }
}