using Flurl.Http;
using Razor_SHOP.Models;

namespace Razor_SHOP.Services
{
    public static class ProductService
    {
        public static List<Product> Products { get; set; } = new();
        public static async Task<List<Product>> GetAllAsync()
        {
            return await "https://localhost:7221/api/Product/info".GetAsync().ReceiveJson<List<Product>>();
        }
    }
   
}
