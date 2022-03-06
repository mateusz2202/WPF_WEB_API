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
            CreateMap<User, UserDTO>();
            CreateMap<InfoProduct, ProductInfoDTO>()
                  .ForMember(x => x.Name, a => a.MapFrom(z => z.Product.Name))
                  .ForMember(x => x.Description, a => a.MapFrom(z => z.Product.Description))
                  .ForMember(x => x.Price, a => a.MapFrom(z => z.Product.Price))
                  .ForMember(x => x.IsAvailable, a => a.MapFrom(z => z.Product.IsAvailable))
                  .ForMember(x => x.Warehouse, a => a.MapFrom(z => z.Warehouse.Name));
                  
  
        }
    }
}
