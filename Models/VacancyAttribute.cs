namespace project.Models
{
    public class VacancyAttribute
    {
        public int Id { get; set; }
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; } = null!;
        public int SkillAttributeId { get; set; }
        public SkillAttribute Attribute { get; set; } = null!;
        public AccessOperator? Operator { get; set; }
        public string? RuleValue { get; set; }
    }

    public enum AccessOperator
    {
        Equals,
        NotEquals,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanEqual
    }
}
