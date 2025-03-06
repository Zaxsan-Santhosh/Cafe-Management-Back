using WebApplication1.DTOs;

namespace WebApplication1.IServices
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<ProductDTO> CreateProductAsync(ProductDTO productDTO);
        Task<bool> UpdateProductAsync(int id, ProductDTO productDTO);
        Task<bool> DeleteProductAsync(int id);
    }
}
