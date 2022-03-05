using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Entities
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; } = null;
        
    }
}