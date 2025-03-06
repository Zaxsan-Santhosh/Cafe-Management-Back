﻿namespace WebApplication1.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int? DiscountId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
