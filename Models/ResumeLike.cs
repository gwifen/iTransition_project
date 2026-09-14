namespace project.Models
{
    public class ResumeLike
    {
        public int ResumeId { get; set; }
        public Resume Resume { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
