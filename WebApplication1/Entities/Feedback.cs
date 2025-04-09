using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }  // Many-to-One

        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
