using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;

namespace project.Services
{
    public class DbSeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _config;

        public DbSeeder(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext dbContext, IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
            _config = config;
        }

        public async Task SeedRolesAsync()
        {
            string[] roles = ["Admin", "Candidate", "Recruiter"];

            foreach (var role in roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }

        }

        public async Task SeedAdminUserAsync()
        {
            string email = _config["AdminCredentials:Email"]!;
            string password = _config["AdminCredentials:Password"]!;

            if (await _userManager.FindByEmailAsync(email) == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    FirstName = "System",
                    LastName = "Admin",
                    EmailConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }


        public async Task SeedAttributeCategoriesAsync()
        {
            string[] categories = ["Certification", "DomainKnowledge", "PersonalInformation", "SocialSkills"];

            foreach(var category in categories)
            {
                if(!await _dbContext.AttributeCategories.AnyAsync(c=>c.Name == category))
                {
                    _dbContext.AttributeCategories.Add(new AttributeCategory
                    {
                        Name = category
                    });
                }
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
