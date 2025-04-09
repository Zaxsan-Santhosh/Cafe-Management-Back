using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
}
