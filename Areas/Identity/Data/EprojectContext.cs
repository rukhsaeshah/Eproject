using Eproject.Areas.Identity.Data;
using Eproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eproject.Data;

public class EprojectContext : IdentityDbContext<EprojectUser>
{
    public EprojectContext(DbContextOptions<EprojectContext> options)
        : base(options)
    {
    }

    public DbSet<Faculty> faculty { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new EprojectUserEntityConfiguration()); 

    }
}

internal class EprojectUserEntityConfiguration : IEntityTypeConfiguration<EprojectUser>
{
    public void Configure(EntityTypeBuilder<EprojectUser> builder)
    {

        builder.Property(x => x.FirstName).HasMaxLength(255);


        builder.Property(x => x.LastName).HasMaxLength(255);


        builder.Property(x => x.Role).HasMaxLength(255).HasDefaultValue('0');
        //throw new NotImplementedException();
    }
}