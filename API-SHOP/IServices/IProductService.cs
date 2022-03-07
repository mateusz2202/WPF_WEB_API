using API_SHOP.Models;

namespace API_SHOP.IServices
{
    public interface IProductService
    {
        List<ProductDTO> GetAll();
        ProductDTO GetById(int id);
        void CreateProduct(ProductDTO dto);
        void UpdateProduct(int id, ProductDTO dto);
        void DeleteProduct(int id);
        List<ProductInfoDTO> GetAllProductInfo();
        void CreateProductInfo(ProductInfoDTO dto);
        void DeleteProductInfo(int id);

    }
}
