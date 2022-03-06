using API_SHOP.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API_SHOP.Data
{
    public class ShopDBInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public ShopDBInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;           
        }

        public void Seed()
        {
            _modelBuilder.Entity<Product>().HasData(GetProducts());
            _modelBuilder.Entity<Role>().HasData(GetRoles());
            _modelBuilder.Entity<User>().HasData(GetUsers());
            _modelBuilder.Entity<Warehouse>().HasData(GetWarehouses());
        }
        private ICollection<Warehouse> GetWarehouses()
        {
            return new List<Warehouse>()
            {
                new Warehouse()
                {
                    Id= 1,
                    Name="Rzeszow"
                },
                new Warehouse()
                {
                    Id=2,
                    Name="Krakow"
                },
                new Warehouse()
                {
                    Id=3,
                    Name="Gdańsk"
                }
            };
        }
        private ICollection<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name="Admin",
                    LastName="Admin",
                    Login="Admin",
                    Password="1234",
                    RoleId =1
                },
                new User()
                {
                    Id = 2,
                    Name="John",
                    LastName="Smith",
                    Login="johns@example.com",
                    Password="1234",
                    RoleId=2
                },
                new User()
                {
                    Id = 3,
                    Name="Peter",
                    LastName="Tank",
                    Login="petero@example.com",
                    Password="1234",
                    RoleId=2
                }
            };
        }
        private ICollection<Role> GetRoles()
        {
            return new List<Role>()
            {
                new Role()
                {
                    Id=1,
                    Name="Admin"
                },
                new Role()
                {
                    Id=2,
                    Name="Customer"
                }
            };
        }
        private ICollection<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id=1,
                    Name="T-shirt",
                    Price=10,
                },
                new Product()
                {
                    Id = 2,
                    Name="Trousers",
                    Price=55,
                },
                new Product()
                {
                    Id=3,
                    Name="Blouse",
                    Price=35,
                },
            };
        }
    }
}
