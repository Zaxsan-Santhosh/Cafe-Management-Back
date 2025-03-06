using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.IServices;
using WebApplication1.DTOs;
using WebApplication1.IRepos;
using System.Threading.Tasks;

namespace WebApplication1.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }
    }
}
