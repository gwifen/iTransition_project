namespace project.Models
{
    public class SkillAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public AttributeCategory Category { get; set; } = null!;
        public AttributeType Type { get; set; }
        
        public ICollection<AttributeOption> Options { get; set; } = new List<AttributeOption>();
        public ICollection<CandidateAttributeValue> CandidateValues { get; set; } = new List<CandidateAttributeValue>();
        public ICollection<VacancyAttribute> VacancyAttributes { get; set; } = new List<VacancyAttribute>();
        public ICollection<ResumeAttributeValue> ResumeValues { get; set; } = new List<ResumeAttributeValue>();
    }

    public enum AttributeType
    {
        String,
        Markdown,
        Image,
        Number,
        Date,
        DateRange,
        Boolean,
        Select
    }
}
