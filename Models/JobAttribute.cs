namespace project.Models
{
    public class JobAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public AttributeCategory Category { get; set; } = null!;
        public AttributeType Type { get; set; }
        
        public ICollection<AttributeOption> Options { get; set; } = new List<AttributeOption>();
        public ICollection<CandidateAttributeValue> CandidateValues { get; set; } = new List<CandidateAttributeValue>();
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
