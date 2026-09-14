namespace project.Models
{
    public class CandidateAttributeValue
    {
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        public int SkillAttributeId { get; set; }
        public SkillAttribute Attribute { get; set; } = null!;
        public string? Value { get; set; }
    }
}
