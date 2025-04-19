using Eproject.Areas.Identity.Data;
using Eproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Eproject.Data;

public class EprojectContext : IdentityDbContext<EprojectUser>
{
    public EprojectContext(DbContextOptions<EprojectContext> options)
        : base(options)
    {
    }

    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // One-to-One: Faculty ↔ EprojectUser
        builder.Entity<Faculty>()
            .HasOne(f => f.User)
            .WithMany()
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // One-to-One: Student ↔ EprojectUser
        builder.Entity<Student>()
            .HasOne(s => s.User)
            .WithMany()
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // One-to-Many: Batch → Students
        builder.Entity<Student>()
            .HasOne(s => s.Batch)
            .WithMany(b => b.Students)
            .HasForeignKey(s => s.BatchId)
            .OnDelete(DeleteBehavior.Cascade);
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