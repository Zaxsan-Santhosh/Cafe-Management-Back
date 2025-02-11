namespace WebApplication1.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
