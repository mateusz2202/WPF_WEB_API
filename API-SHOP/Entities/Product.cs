namespace API_SHOP.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Description { get; set; }
        public decimal Price { get; set; }
        bool IsAvailable { get; set; }
        public List<InfoProduct> InfoProducts { get; set; }
    }
}
