using WebApplication1.Entities;

namespace WebApplication1.IServices
{
    public interface IDiscountService
    {
        Task<List<Discount>> GetAllDiscounts();
        Task<Discount> GetDiscountById(int id);
        Task<Discount> CreateDiscount(Discount discount);
        Task<bool> UpdateDiscount(int id, Discount discount);
        Task<bool> DeleteDiscount(int id);
    }
}
