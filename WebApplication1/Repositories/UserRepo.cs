
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


        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _appDbContext.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _appDbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            await _appDbContext.Users.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }


        public async Task<bool> UpdateUserAsync(User user)
        {
            var existingUser = await _appDbContext.Users.FindAsync(user.Id);
            if (existingUser == null) return false;

            _appDbContext.Entry(existingUser).CurrentValues.SetValues(user);
            await _appDbContext.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id);
            if (user == null) return false;

            _appDbContext.Users.Remove(user);
            await _appDbContext.SaveChangesAsync();
            return true;
        }






    }
}
