namespace API_SHOP.Models
{
    public class ProductInfoDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }       
        public string Warehouse { get; set; }
        public int Count { get; set; }
    }
}
