using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.IServices;
using WebApplication1.DTOs;
using WebApplication1.IRepos;
using System.Threading.Tasks;

namespace WebApplication1.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
