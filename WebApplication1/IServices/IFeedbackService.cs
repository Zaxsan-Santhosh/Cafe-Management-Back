using WebApplication1.Entities;

namespace WebApplication1.IServices
{
    public interface IFeedbackService
    {
        Task<Feedback> GetFeedbackById(int id);
        Task<List<Feedback>> GetAllFeedbacks();
        Task<Feedback> CreateFeedback(Feedback feedback);
        Task UpdateFeedback(Feedback feedback);
        Task DeleteFeedback(int id);
    }
}
