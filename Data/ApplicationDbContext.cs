using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SkillAttribute> Attributes { get; set; }
        public DbSet<AttributeCategory> AttributeCategories { get; set; }
        public DbSet<AttributeOption> AttributeOptions { get; set; }
        public DbSet<CandidateAttributeValue> CandidateAttributeValues { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyAttribute> VacancyAttributes { get; set; }
        public DbSet<TechTag> TechTags { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<ResumeAttributeValue> ResumeAttributeValues { get; set; }
        public DbSet<ResumeLike> ResumeLikes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                .Property(x => x.Version)
                .IsConcurrencyToken();
            builder.Entity<SkillAttribute>()
                .HasIndex(x => x.Name)
                .IsUnique();
            builder.Entity<CandidateAttributeValue>()
                .HasKey(x => new { x.SkillAttributeId, x.UserId });
            builder.Entity<VacancyAttribute>()
                .HasKey(x => new { x.VacancyId, x.SkillAttributeId });
            builder.Entity<ResumeAttributeValue>()
                .HasKey(x => new { x.ResumeId, x.SkillAttributeId });
            builder.Entity<ResumeLike>()
                .HasKey(x => new { x.UserId, x.ResumeId });
        }
    }
}
