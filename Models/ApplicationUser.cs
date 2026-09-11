using Microsoft.AspNetCore.Identity;

namespace project.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Photo { get; set; }
        public Guid Version { get; set; }

        public ICollection<CandidateAttributeValue> AttributeValues { get; set; } = new List<CandidateAttributeValue>();
    }

}
