using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.IServices;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService feedbackService;
        public FeedbackController(IFeedbackService feedbackService)
        {
            feedbackService = feedbackService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Feedback>>> GetAllFeedbacks()
        {
            return await feedbackService.GetAllFeedbacks();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedbackById(int id)
        {
            var feedback = await feedbackService.GetFeedbackById(id);
            if (feedback == null)
            {
                return NotFound();
            }
            return feedback;
        }
        [HttpPost]
        public async Task<ActionResult<Feedback>> CreateFeedback(Feedback feedback)
        {
            var newFeedback = await feedbackService.CreateFeedback(feedback);
            return CreatedAtAction(nameof(GetFeedbackById), new { id = newFeedback.Id }, newFeedback);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFeedback(int id, Feedback feedback)
        {
            if (id != feedback.Id)
            {
                return BadRequest();
            }
            await feedbackService.UpdateFeedback(feedback);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            var feedback = await feedbackService.GetFeedbackById(id);
            if (feedback == null)
            {
                return NotFound();
            }
            await feedbackService.DeleteFeedback(id);
            return NoContent();
        }
    }
}
