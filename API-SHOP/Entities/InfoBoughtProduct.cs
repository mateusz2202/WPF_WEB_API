namespace API_SHOP.Entities
{
    public class InfoBoughtProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public int ShoppingBasketId { get; set; }
        public ShoppingBasket ShoppingBasket { get; set; }
    }
}
