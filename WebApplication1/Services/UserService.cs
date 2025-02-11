using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class UserService:IUserService
    {
        public readonly IUserRepo _userRepo;
        public UserService (IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }


        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetUserByIdAsync(id);
        }


        public async Task<User> CreateUserAsync(User user)
        {
            return await _userRepo.CreateUserAsync(user);
        }


        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _userRepo.UpdateUserAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userRepo.DeleteUserAsync(id);
        }

    }
}
