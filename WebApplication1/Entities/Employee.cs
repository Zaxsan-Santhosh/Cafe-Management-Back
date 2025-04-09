using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public ICollection<Order> OrdersHandled { get; set; }  // Optional Many-to-Many relation
    }
}
