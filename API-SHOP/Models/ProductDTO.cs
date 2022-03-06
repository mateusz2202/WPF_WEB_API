namespace API_SHOP.Models
{
    public class ProductDTO
    {        
        public string? Name { get; set; } 
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
