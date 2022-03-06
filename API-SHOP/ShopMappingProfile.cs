using API_SHOP.Entities;
using API_SHOP.Models;
using AutoMapper;

namespace API_SHOP
{
    public class ShopMappingProfile : Profile
    {
        public ShopMappingProfile()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
  
        }
    }
}
