using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Iamge { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public decimal? Discount { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public Inventory Inventory { get; set; }
    }
}
