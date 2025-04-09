using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class FeedbackRepo : IFeedbackRepo
    {
        private readonly AppDbContext _context;

        public FeedbackRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Feedback> CreateFeedback(Feedback feedback)
        {
            await _context.Feedbacks.AddAsync(feedback);
            await _context.SaveChangesAsync();
            return feedback;
        }

        public async Task<List<Feedback>> GetAllFeedbacks()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        public async Task<Feedback> GetFeedbackById(int id)
        {
            return await _context.Feedbacks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateFeedback(Feedback feedback)
        {
            _context.Feedbacks.Update(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeedback(int id)
        {
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Id == id);
            _context.Feedbacks.Remove(feedback);
            await _context.SaveChangesAsync();
        }
    }
}
