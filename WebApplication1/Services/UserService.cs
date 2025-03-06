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

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepo.GetAllUsersAsync();

            // Convert List<User> to List<UserDTO>
            return users.Select(u => new UserDTO
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                Role = u.Role,
                CreatedAt = u.CreatedAt,
                Orders = u.Orders?.Select(o => new OrderDTO
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount,
                    Status = (int)o.Status // Explicit conversion from OrderStatus to int
                }).ToList()
            }).ToList();
        }


        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepo.GetUserByIdAsync(id);
            if (user == null) return null;

            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                Orders = user.Orders?.Select(o => new OrderDTO
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount,
                    Status = (int)o.Status // Explicit conversion from OrderStatus to int
                }).ToList()
            };
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
