namespace project.Models
{
    public class ResumeAttributeValue
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; } = null!;
        public int SkillAttributeId { get; set; }
        public SkillAttribute Attribute { get; set; } = null!;
        public string Value { get; set; } = string.Empty;
    }
}
