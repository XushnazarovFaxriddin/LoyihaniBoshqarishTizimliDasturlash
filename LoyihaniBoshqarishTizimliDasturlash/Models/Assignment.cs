namespace LoyihaniBoshqarishTizimliDasturlash.Models
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Image> Images { get; set; }
        public Guid? DeveloperId { get; set; }
        public Developer? Developer { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public AssignmentStatus Status { get; set; } = AssignmentStatus.New;
        public Job? Job { get; set; }
        public Guid JobId { get; set; }
    }

    public enum AssignmentStatus
    {
        New,
        InProgress,
        Canceled,
        Completed
    }
}
