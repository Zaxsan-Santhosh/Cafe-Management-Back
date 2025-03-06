using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class ProductRepo : IProductRepo
    {
        
        private readonly AppDbContext _appDbContext;


        public ProductRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _appDbContext.Products.Include(p => p.Category).Include(p => p.Discount).ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _appDbContext.Products.Include(p => p.Category).Include(p => p.Discount).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var existingProduct = await _appDbContext.Products.FindAsync(product.Id);
            if (existingProduct == null) return false;

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.DiscountId = product.DiscountId;

            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _appDbContext.Products.FindAsync(id);
            if (product == null) return false;

            _appDbContext.Products.Remove(product);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
