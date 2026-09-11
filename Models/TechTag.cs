namespace project.Models
{
    public class TechTag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
    }
}
