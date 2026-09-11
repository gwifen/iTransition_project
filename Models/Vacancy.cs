namespace project.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public int MaxProjects { get; set; }

        public ICollection<SkillAttribute> Attributes { get; set; } = new List<SkillAttribute>();
        public ICollection<TechTag> TechTags { get; set; } = new List<TechTag>();
    }
}
