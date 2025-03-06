using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public Order Order { get; set; }
    }

    public enum PaymentMethod
    {
        Cash,
        Card,
        Online
    }
}
