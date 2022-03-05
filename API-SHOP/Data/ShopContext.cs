using API_SHOP.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_SHOP.Data
{
    public class ShopContext : DbContext
    {

        public DbSet<Product> Products { get; set; } = null;
    }
}
