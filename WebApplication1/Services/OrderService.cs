using System.Linq;
using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<List<OrderDTO>> GetAllOrders()
        {
            var orders = await _orderRepo.GetAllOrders();
            return orders.Select(o => new OrderDTO
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalAmount = o.TotalAmount,
                Status = (int)o.Status
            }).ToList();
        }


        public async Task<OrderDTO> GetOrderById(int id)
        {
            var order = await _orderRepo.GetOrderById(id);
            if (order == null) return null;

            return new OrderDTO
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                Status = (int)order.Status
            };

        }

        public async Task<OrderDTO> CreateOrder (OrderDTO orderDTO)
        {
            var order = new Order
            {
                OrderDate = orderDTO.OrderDate,
                TotalAmount = orderDTO.TotalAmount,
                Status = (OrderStatus)orderDTO.Status
            };

            return new OrderDTO
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                Status = (int)order.Status
            };
        }

        public async Task<bool> UpdateOrder (int id , OrderDTO order)
        {
            var existing = await _orderRepo.GetOrderById(id);

            if (existing == null) return false;

            existing.OrderDate = order.OrderDate;
            existing.TotalAmount = order.TotalAmount;
            existing.Status = (OrderStatus)order.Status;

            await _orderRepo.UpdateOrder(existing);
            return true;


        }


        public async Task<bool> DeleteOrder(int id)
        {
            var existing = await _orderRepo.GetOrderById(id);
            if (existing == null) return false;
            await _orderRepo.DeleteOrder(id);
            return true;
        }
    }
}
