using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? OrderId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public User User { get; set; }
        public Order Order { get; set; }
    }
}
