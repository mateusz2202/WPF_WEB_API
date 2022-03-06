using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Entities
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string? Name { get; set; }
        [MaxLength(255)]
        [Required]
        public string? LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string? Login { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(32)]
        public string ?Password { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }=null;
        public bool IsAvailable { get; set; } = true;
    }
}
