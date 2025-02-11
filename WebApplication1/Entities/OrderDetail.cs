using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }

        // Relationships
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
