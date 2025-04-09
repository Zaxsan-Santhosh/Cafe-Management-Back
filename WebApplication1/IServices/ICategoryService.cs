using WebApplication1.Entities;

namespace WebApplication1.IServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategory();
        Task<Category> GetCategoryById(int id);
        Task<Category> CreateCategory(Category category);
        Task<bool> UpdateCategory(int id, Category category);
        Task<bool> DeleteCategory(int id);
    }
}
