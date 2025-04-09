using WebApplication1.Entities;
using WebApplication1.DTOs;

namespace WebApplication1.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUser(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
