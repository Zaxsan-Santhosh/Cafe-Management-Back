using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepo(AppDbContext appDbContext)
        {
            appDbContext = appDbContext;
        }

        public async Task<List<Category>> GetAllCategory()
        {
            return await appDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await appDbContext.Categories.FindAsync(id);
        }

        public async Task<Category> CreateCategory(Category category)
        {
            appDbContext.Categories.Add(category);
            await appDbContext.SaveChangesAsync();
            return category;
        }

        public async Task UpdateCategory(Category category)
        {
            appDbContext.Categories.Update(category);
            await appDbContext.SaveChangesAsync();
            
        }

        public async Task DeleteAsync(int id)
        {
           var category = await appDbContext.Categories.FindAsync(id);
            if (category != null)
            {
                appDbContext.Categories.Remove(category);
                await appDbContext.SaveChangesAsync();

            }
            
        }


    }
}
