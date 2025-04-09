using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        public async Task<List<Category>> GetAllCategory()
        {
            return await _categoryRepo.GetAllCategory();
        }


        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepo.GetCategoryById(id);
        }

        public async Task<Category> CreateCategory(Category category)
        {
            return await _categoryRepo.CreateCategory(category);
        }

        public async Task<bool> UpdateCategory(int id, Category category)
        {
            var existingCategory = await _categoryRepo.GetCategoryById(id);
            if (existingCategory == null) return false;

            existingCategory.Name = category.Name;
            await _categoryRepo.UpdateCategory(existingCategory);
            return true;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var existingCategory = await _categoryRepo.GetCategoryById(id);
            if (existingCategory == null) return false;

            await _categoryRepo.DeleteAsync(id);
            return true;
        }

    }
}
