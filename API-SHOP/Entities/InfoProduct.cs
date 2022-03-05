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
        [Required]
        public int WarehouseId { get; set; }
        public Warehouse? Warehouse { get; set; } = null;
    }
}
