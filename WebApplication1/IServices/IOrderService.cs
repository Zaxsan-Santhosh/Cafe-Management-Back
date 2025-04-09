using WebApplication1.DTOs;

namespace WebApplication1.IServices
{
    public interface IOrderService
    {
        Task<List<OrderDTO>> GetAllOrders();
        Task<OrderDTO> GetOrderById(int id);
        Task<OrderDTO> CreateOrder(OrderDTO orderDTO);
        Task<bool> UpdateOrder(int id, OrderDTO order);
        Task<bool> DeleteOrder(int id);
    }
}
