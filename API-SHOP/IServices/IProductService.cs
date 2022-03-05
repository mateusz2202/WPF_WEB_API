using API_SHOP.Entities;

namespace API_SHOP.IServices
{
    public interface IProductService
    {
        List<Product>GetAll();
        Product GetById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(int id,Product product);
        void DeleteProduct(int id);
    }
}
