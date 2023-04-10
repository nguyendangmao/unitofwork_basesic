
using UnitOfWork_PhamTruong.DTOs.ProductDto;
using UnitOfWork_PhamTruong.Entities;

namespace UnitOfWork_PhamTruong.Service
{
    public interface IProductService
    {
        Task<bool> CreateProduct(productDto Product);
        Task<IEnumerable<productDto>> GetAllProducts();

        Task<productDto> GetProductById(int productId);

        Task<bool> UpdateProduct(productDto Product);

        Task<bool> DeleteProduct(int productId);
    }
}
