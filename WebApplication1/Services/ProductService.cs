using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepo.GetAllProductsAsync();
            return products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                DiscountId = p.DiscountId
            }).ToList();
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product = await _productRepo.GetProductByIdAsync(id);
            if (product == null) return null;
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId,
                DiscountId = product.DiscountId
            };
        }

        public async Task<ProductDTO> CreateProductAsync(ProductDTO productDTO)
        {
            var product = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                CategoryId = productDTO.CategoryId,
                DiscountId = productDTO.DiscountId
            };

            var createdProduct = await _productRepo.CreateProductAsync(product);
            productDTO.Id = createdProduct.Id;
            return productDTO;
        }


        public async Task<bool> UpdateProductAsync(int id , ProductDTO productDTO)
        {
            var product = new Product
            {
                Id = id,
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                CategoryId = productDTO.CategoryId,
                DiscountId = productDTO.DiscountId
            };

            return await _productRepo.UpdateProductAsync(product);
        }


        public async Task<bool> DeleteProductAsync(int id)
        {
            return await _productRepo.DeleteProductAsync(id);
        }
    }
}
