using API_SHOP.Entities;

namespace API_SHOP.Models
{
    public class UserDTO
    {      
        public string? Name { get; set; }
   
        public string? LastName { get; set; }
      
        public string? Login { get; set; } 
   
        public int RoleId { get; set; }       
        public bool IsAvailable { get; set; } 
    }
}
