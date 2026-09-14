namespace project.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public int MaxProjects { get; set; }

        public ICollection<VacancyAttribute> VacancyAttributes { get; set; } = new List<VacancyAttribute>();
        public ICollection<TechTag> TechTags { get; set; } = new List<TechTag>();
        public ICollection<Resume> Resumes { get; set; } = new List<Resume>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
