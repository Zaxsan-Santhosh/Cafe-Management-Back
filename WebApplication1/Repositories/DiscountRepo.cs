using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class DiscountRepo : IDiscountRepo
    {
        private readonly AppDbContext _appDbContext;

        public DiscountRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<List<Discount>> GetAllDiscounts()
        {
       
            return await _appDbContext.Discounts.ToListAsync();
        }

        public async Task<Discount> GetDiscountById(int id)
        {
            return await _appDbContext.Discounts.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task CreateDiscount(Discount discount)
        {
            _appDbContext.Discounts.Add(discount);
            await _appDbContext.SaveChangesAsync();
            
        }

        public async Task UpdateDiscount(Discount discount)
        {
            _appDbContext.Discounts.Update(discount);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteDiscount(int id)
        {
            var discount = await _appDbContext.Discounts.FindAsync(id);
            if (discount != null)
            {
                _appDbContext.Discounts.Remove(discount);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
