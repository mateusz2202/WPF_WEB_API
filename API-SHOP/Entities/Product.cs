using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SHOP.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string? Name { get; set; } = null;
        public string? Description { get; set; } = null;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public List<InfoProduct>? InfoProducts { get; set; } = null;
    }
}
