using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_SHOP.Models;
using Razor_SHOP.Services;

namespace Razor_SHOP.Pages
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; } = new();
        public async Task OnGetAsync()
        {
            Products=await ProductService.GetAllAsync();
        }
    }
}
