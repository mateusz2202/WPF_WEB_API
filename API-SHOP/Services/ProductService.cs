using API_SHOP.Data;
using API_SHOP.Entities;
using API_SHOP.Exceptions;
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
           var product=_mapper.Map<Product>(dto);
            _dbContext.Products?.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product= _dbContext.Products?.FirstOrDefault(x => x.Id == id);
            if (product is null) throw new NotFoundException("Product not found");
            _dbContext.Products?.Remove(product);
            _dbContext.SaveChanges();
        }

        public List<ProductDTO> GetAll()
        {
            var products = _dbContext.Products?.ToList();
            var productsDto=_mapper.Map<List<ProductDTO>>(products);
            return productsDto;
        }

        public ProductDTO GetById(int id)
        {
            var product=_dbContext.Products?.FirstOrDefault(x=>x.Id == id);
            if (product is null) throw new NotFoundException("Product not found");
            var result=_mapper.Map<ProductDTO>(product);
            return result;
        }

        public void UpdateProduct(int id, ProductDTO dto)
        {
            var product = _dbContext.Products?.FirstOrDefault(x => x.Id == id);
            if (product is null) throw new NotFoundException("Product not found");
            product.Name = dto.Name;
            product.Description = dto.Description;
            product.Price = dto.Price;
            product.IsAvailable = dto.IsAvailable;
            _dbContext.SaveChanges();
        }
    }
}
