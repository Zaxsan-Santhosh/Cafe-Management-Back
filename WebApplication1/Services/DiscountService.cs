using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepo _discountRepo;

        public DiscountService(IDiscountRepo discountRepo)
        {
            _discountRepo = discountRepo;
        }

        public async Task<List<Discount>> GetAllDiscounts()
        {
            return await _discountRepo.GetAllDiscounts();
        }

        public async Task<Discount> GetDiscountById(int id)
        {
            return await _discountRepo.GetDiscountById(id);
        }

        public async Task<Discount> CreateDiscount(Discount discount)
        {
            await _discountRepo.CreateDiscount(discount);
            return discount;
        }

        public async Task<bool> UpdateDiscount(int id, Discount discount)
        {
            var existingDiscount = await _discountRepo.GetDiscountById(id);
            if (existingDiscount == null) return false;

            existingDiscount.Name = discount.Name;
            existingDiscount.Percentage = discount.Percentage;
            await _discountRepo.UpdateDiscount(existingDiscount);
            return true;
        }

        public async Task<bool> DeleteDiscount(int id)
        {
            var existingDiscount = await _discountRepo.GetDiscountById(id);
            if (existingDiscount == null) return false;

            await _discountRepo.DeleteDiscount(id);
            return true;
        }
    }
}
