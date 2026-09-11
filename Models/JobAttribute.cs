namespace project.Models
{
    public class JobAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public required AttributeCategory Category { get; set; }
        public AttributeType Type { get; set; }
        public ICollection<AttributeOption> Options { get; set; } = new List<AttributeOption>();
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
