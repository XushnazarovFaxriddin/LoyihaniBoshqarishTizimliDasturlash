namespace LoyihaniBoshqarishTizimliDasturlash.Models
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public Guid DeveloperTypeId { get; set; }
        public DeveloperType DeveloperType { get; set; }

        public string Name => ((FirstName + " " + MiddleName).Trim() + " " + LastName).Trim();
    }
    public class DeveloperType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

