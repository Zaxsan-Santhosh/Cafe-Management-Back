using WebApplication1.Entities;

namespace WebApplication1.IRepos
{
    public interface ICategoryRepo
    {
        Task<List<Category>> GetAllCategory();
        Task<Category> GetCategoryById(int id);
        Task<Category> CreateCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteAsync(int id);
    }
}
