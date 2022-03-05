using API_SHOP.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_SHOP.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<WareHouse>? WareHouses { get; set; }
        public DbSet<InfoProduct>? InfoProducts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<ShoppingBasket>? ShoppingBaskets { get; set; }
        public DbSet<InfoBoughtProduct>? InfoBoughtProducts { get; set; }
    }
}
