namespace API_SHOP.Models
{
    public class ProductDTO
    {        
        public string? Name { get; set; } 
        public int? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
