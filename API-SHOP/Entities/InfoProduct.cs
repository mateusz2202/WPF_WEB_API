using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Entities
{
    public class InfoProduct
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; } = null;
        [Required]
        public int Count { get; set; } = 0;
        public int? WareHouseId { get; set; } = null;
        public WareHouse? WareHouse { get; set; } = null;
    }
}
