using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;

namespace project.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public ProfileService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<ApplicationUser?> GetUserProfileAsync(string userId)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            return await context.Users
                .Include(u => u.AttributeValues)
                    .ThenInclude(av => av.Attribute)
                .Include(u => u.Projects)
                    .ThenInclude(p => p.TechTags)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task UpdateProfileAsync(ApplicationUser user)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            context.Attach(user);
            var entry = context.Entry(user);
            entry.Property(u => u.FirstName).IsModified = true;
            entry.Property(u => u.LastName).IsModified = true;
            entry.Property(u => u.City).IsModified = true;
            entry.Property(u => u.Country).IsModified = true;
            user.Version = Guid.NewGuid();
            entry.Property(u => u.Version).IsModified = true;

            foreach (var attrValue in user.AttributeValues)
            {
                context.Attach(attrValue);
                context.Entry(attrValue).Property(v => v.Value).IsModified = true;
                //attrValue.Version = Guid.NewGuid();
                //context.Entry(attrValue).Property(v => v.Version).IsModified = true;
            }
            await context.SaveChangesAsync();
        }
    }
}
