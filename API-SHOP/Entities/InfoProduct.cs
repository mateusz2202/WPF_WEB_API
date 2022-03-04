namespace API_SHOP.Entities
{
    public class InfoProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public int WareHouseId { get; set; }
        public WareHouse WareHouse { get; set; }
    }
}
