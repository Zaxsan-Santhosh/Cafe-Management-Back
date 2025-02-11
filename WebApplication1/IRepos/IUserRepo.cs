using WebApplication1.Entities;

namespace WebApplication1.IRepos
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);

    }
}
