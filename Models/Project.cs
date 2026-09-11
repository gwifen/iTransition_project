namespace project.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Discription { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<TechTag> TechTags { get; set; } = new List<TechTag>();
    }
}
