using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Entities
{
    public class ShoppingBasket
    {
        public int Id { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public virtual List<InfoBoughtProduct>? InfoBoughtProducts { get; set; }=null;
        public DateTime? Finished { get; set; }
        public int UserId { get; set; }
        [Required]
        public User? User { get; set; }=null;

    }
}
