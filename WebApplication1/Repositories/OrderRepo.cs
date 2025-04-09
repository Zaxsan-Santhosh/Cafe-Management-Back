using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _appDbContext.Orders.Include(o => o.User).Include(o => o.Payment).ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _appDbContext.Orders.Include(o => o.User).Include(o => o.Payment).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task CreateOrder(Order order)
        {
            _appDbContext.Orders.Add(order);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task UpdateOrder(Order order)
        {
            _appDbContext.Orders.Update(order);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _appDbContext.Orders.FindAsync(id);
            if (order != null)
            {
                _appDbContext.Orders.Remove(order);
                await _appDbContext.SaveChangesAsync();
            }
        }

    }
}
