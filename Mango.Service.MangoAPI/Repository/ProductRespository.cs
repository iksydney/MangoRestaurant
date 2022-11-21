using Mango.Service.MangoAPI.DTO;

namespace Mango.Service.MangoAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> CreateProduct(ProductDTO model);
        Task<bool> DeleteProduct(int id);
    }
    public class ProductRespository : IProductRepository
    {
        public Task<ProductDTO> CreateProduct(ProductDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
