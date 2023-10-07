namespace LoyihaniBoshqarishTizimliDasturlash.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string Base64 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Guid? AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }
    }
}
