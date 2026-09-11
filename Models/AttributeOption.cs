namespace project.Models
{
    public class AttributeOption
    {
        public int Id { get; set; }
        public int JobAttributeId { get; set; }
        public JobAttribute Attribute { get; set; } = null!;
        public string Value { get; set; } = string.Empty;
    }
}
