using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }  // Fixed the enum property

        public ICollection<Order> Orders { get; set; }  // One-to-Many
        public ICollection<Feedback> Feedbacks { get; set; } // One-to-Many
    }

    public enum UserRole
    {
        Customer,
        Employee,
        Admin
    }
}
