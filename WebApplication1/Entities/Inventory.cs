using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockLevel { get; set; }
        public DateTime RestockDate { get; set; }

        // Relationships
        public Product Product { get; set; }
    }
}
