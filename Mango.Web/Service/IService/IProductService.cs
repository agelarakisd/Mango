using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDTO?> GetProductAsync(string productDTO);
        Task<ResponseDTO?> GetAllProductsAsync();
        Task<ResponseDTO?> GetProductByIdAsync(int id);
        Task<ResponseDTO?> CreateProductsAsync(ProductDTO productDTO);
        Task<ResponseDTO?> UpdateProductsAsync(ProductDTO productDTO);
        Task<ResponseDTO?> DeleteProductAsync(int id);
    }
}
