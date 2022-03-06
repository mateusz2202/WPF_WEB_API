namespace API_SHOP.Models
{
    public class ProductDTO
    {        
        public string? Name { get; set; } = null;
        public int? Description { get; set; } = null;   
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;     
    }
}
