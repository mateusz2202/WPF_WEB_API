using API_SHOP.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_SHOP.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ShopDBInitializer(modelBuilder).Seed();
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Warehouse>? Warehouses { get; set; }
        public DbSet<InfoProduct>? InfoProducts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<ShoppingBasket>? ShoppingBaskets { get; set; }
        public DbSet<InfoBoughtProduct>? InfoBoughtProducts { get; set; }
    }
}
