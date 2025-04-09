using WebApplication1.Entities;

namespace WebApplication1.IRepos
{
    public interface IDiscountRepo
    {
        Task<List<Discount>> GetAllDiscounts();
        Task<Discount> GetDiscountById(int id);
        Task CreateDiscount(Discount discount);
        Task UpdateDiscount(Discount discount);
        Task DeleteDiscount(int id);
    }
}
