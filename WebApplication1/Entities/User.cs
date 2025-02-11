using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public List<Order> Orders { get; set; } = new List<Order>();
        public Employee EmployeeInfo { get; set; }
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }

    public enum UserRole
    {
        Customer,
        Employee,
        Admin
    }
}
