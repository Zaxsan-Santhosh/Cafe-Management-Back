using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }  // Many-to-One

        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }  // One-to-Many
        public Payment Payment { get; set; } // One-to-One
    }

    public enum OrderStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}