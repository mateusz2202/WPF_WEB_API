using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Entities
{
    public class WareHouse
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }=string.Empty;
        public virtual List<InfoProduct>? InfoProducts { get; set; } = null;
        public bool IsAvailable { get; set; } = true;
    }
}
