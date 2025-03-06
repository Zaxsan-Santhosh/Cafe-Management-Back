using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Discount
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } 

        [Range(0, 100)]
        public double Percentage { get; set; } 

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } 

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
