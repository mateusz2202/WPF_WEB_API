using API_SHOP.Entities;
using API_SHOP.Models;

namespace API_SHOP.IServices
{
    public interface IProductService
    {
        List<Product>GetAll();
        Product GetById(int id);
        void CreateProduct(ProductDTO dto);
        void UpdateProduct(int id, ProductDTO dto);
        void DeleteProduct(int id);
    }
}
