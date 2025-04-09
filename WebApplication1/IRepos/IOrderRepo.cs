using WebApplication1.Entities;

namespace WebApplication1.IRepos
{
    public interface IOrderRepo
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int id);
    }
}
