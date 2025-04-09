using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }  // Many-to-One

        public int ProductId { get; set; }
        public Product Product { get; set; } // Many-to-One

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
