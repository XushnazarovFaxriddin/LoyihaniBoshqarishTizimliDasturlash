﻿namespace LoyihaniBoshqarishTizimliDasturlash.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
