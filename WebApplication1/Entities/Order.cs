using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public int? PaymentId { get; set; }
        public decimal? Discount { get; set; }

        // Relationships
        public User User { get; set; }
        public Payment Payment { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }

    public enum OrderStatus
    {
        Pending,
        Completed,
        Cancelled
    }
}