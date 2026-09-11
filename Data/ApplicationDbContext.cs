using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<JobAttribute> Attributes { get; set; }
        public DbSet<AttributeCategory> AttributeCategories { get; set; }
        public DbSet<AttributeOption> AttributeOptions { get; set; }
        public DbSet<CandidateAttributeValue> CandidateAttributeValues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                .Property(x => x.Version)
                .IsConcurrencyToken();
            builder.Entity<JobAttribute>()
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
