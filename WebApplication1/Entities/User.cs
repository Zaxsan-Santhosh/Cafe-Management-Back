using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [JsonIgnore] // Prevent exposing password in API responses
        public string Password { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public List<Order> Orders { get; set; } = new List<Order>();
        public Employee EmployeeInfo { get; set; }
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        // If Discounts Apply to Specific Users
        public List<Discount> Discounts { get; set; } = new List<Discount>();
    }

}

public enum UserRole
{
    Customer,
    Employee,
    Admin
}
