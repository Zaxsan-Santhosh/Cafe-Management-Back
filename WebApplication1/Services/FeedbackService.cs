using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepo feedbackRepo;

        public FeedbackService(IFeedbackRepo feedbackRepo)
        {
            feedbackRepo = feedbackRepo;
        }

        public async Task<Feedback> GetFeedbackById(int id)
        {
            return await feedbackRepo.GetFeedbackById(id);
        }

        public async Task<List<Feedback>> GetAllFeedbacks()
        {
            return await feedbackRepo.GetAllFeedbacks();
        }

        public async Task<Feedback> CreateFeedback(Feedback feedback)
        {
            return await feedbackRepo.CreateFeedback(feedback);
        }

        public async Task UpdateFeedback(Feedback feedback)
        {
            await feedbackRepo.UpdateFeedback(feedback);
        }

        public async Task DeleteFeedback(int id)
        {
            await feedbackRepo.DeleteFeedback(id);
        }

    }
}
