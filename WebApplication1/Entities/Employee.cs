using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        // Relationships
        public User User { get; set; }
    }
}
