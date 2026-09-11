namespace project.Models
{
    public class AttributeOption
    {
        public int Id { get; set; }
        public int JobAttributeId { get; set; }
        public required JobAttribute Attribute { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}
