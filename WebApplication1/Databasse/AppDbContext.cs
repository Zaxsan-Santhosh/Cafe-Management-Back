using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Databasse
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
    {
    } 

        public DbSet<User>Users { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails { get; set; }
        public DbSet<Payment>Payments { get; set; }
        public DbSet<Inventory>Inventories { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Feedback>Feedbacks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Ensures proper cascading delete behavior
        }

    }



}

