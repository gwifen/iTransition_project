using project.Models;

namespace project.Services
{
    public interface IProfileService
    {
        Task<ApplicationUser?> GetUserProfileAsync(string userId);
        Task UpdateProfileAsync(ApplicationUser user);
    }
}