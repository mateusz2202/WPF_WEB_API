using API_SHOP.Data;
using API_SHOP.Entities;
using API_SHOP.IServices;
using API_SHOP.Models;
using AutoMapper;

namespace API_SHOP.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(ShopDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, ProductDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
