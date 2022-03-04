namespace API_SHOP.Entities
{
    public class ShoppingBasket
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public virtual List<InfoBoughtProduct> InfoBoughtProducts { get; set; }
        public DateTime? Finished { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
