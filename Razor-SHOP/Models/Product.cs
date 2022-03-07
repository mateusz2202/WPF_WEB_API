using Microsoft.AspNetCore.Mvc;

namespace Razor_SHOP.Models
{
    [BindProperties]
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string? Warehouse { get; set; }
        public int Count { get; set; }
    }
}
