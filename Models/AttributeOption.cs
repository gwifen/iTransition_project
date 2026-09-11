namespace project.Models
{
    public class AttributeOption
    {
        public int Id { get; set; }
        public int SkillAttributeId { get; set; }
        public SkillAttribute Attribute { get; set; } = null!;
        public string Value { get; set; } = string.Empty;
    }
}
