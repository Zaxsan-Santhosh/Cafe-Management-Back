using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }  // One-to-One

        public decimal Amount { get; set; }
        public paymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public enum paymentMethod
    {
        Cash,
        Card,
        Online
    }
}
