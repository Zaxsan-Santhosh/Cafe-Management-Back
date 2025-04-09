
using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class UserRepo : IUserRepo
    {
        public readonly AppDbContext _appDbContext;
        public UserRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _appDbContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _appDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task CreateUserAsync(User user)
        {
            await _appDbContext.Users.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
        }


        public async Task UpdateUserAsync(User user)
        {
           _appDbContext.Users.Update(user);
           await _appDbContext.SaveChangesAsync();
        }


        public async Task DeleteUserAsync(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id);
            if (user != null)
            {
                _appDbContext.Users.Remove(user);
                await _appDbContext.SaveChangesAsync();
            }

            
        }






    }
}
