using WebApplication1.Entities;

namespace WebApplication1.IRepos
{
    public interface IFeedbackRepo
    {
        Task<Feedback> CreateFeedback(Feedback feedback);
        Task<List<Feedback>> GetAllFeedbacks();
        Task<Feedback> GetFeedbackById(int id);
        Task UpdateFeedback(Feedback feedback);
        Task DeleteFeedback(int id);
    }
}
