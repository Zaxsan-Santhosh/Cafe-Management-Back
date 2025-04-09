using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.IServices;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Discount>>> GetAllDiscounts()
        {
            return await _discountService.GetAllDiscounts();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Discount>> GetDiscountById(int id)
        {
            var discount = await _discountService.GetDiscountById(id);
            if (discount == null)
            {
                return NotFound();
            }
            return discount;
        }
        [HttpPost]
        public async Task<ActionResult<Discount>> CreateDiscount(Discount discount)
        {
            await _discountService.CreateDiscount(discount);
            return CreatedAtAction("GetDiscountById", new { id = discount.Id }, discount);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDiscount(int id, Discount discount)
        {
            if (id != discount.Id)
            {
                return BadRequest();
            }
            var updated = await _discountService.UpdateDiscount(id, discount);
            if (!updated)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var deleted = await _discountService.DeleteDiscount(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
