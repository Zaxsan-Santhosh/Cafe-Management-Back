using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public double Percentage { get; set; } 
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
