using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;


namespace WebApplication1.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService (IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }


        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetUserByIdAsync(id);
        }


        public async Task AddUser(User user)
        {
            await _userRepo.CreateUserAsync(user);
        }


        public async Task UpdateUserAsync(User user)
        {
            await _userRepo.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepo.DeleteUserAsync(id);
        }

    }
}
