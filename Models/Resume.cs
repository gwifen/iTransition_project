using System.Diagnostics;

namespace project.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; } = null!;
        public ResumeStatus Status { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<ResumeAttributeValue> AttributeValues { get; set; } = new List<ResumeAttributeValue>();
        public ICollection<ResumeLike> ResumeLikes { get; set; } = new List<ResumeLike>();
    }

    public enum ResumeStatus
    {
        Draft,
        Published,
        Interview,
        Accepted,
        Rejected
    }
}
