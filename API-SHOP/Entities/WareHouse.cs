namespace API_SHOP.Entities
{
    public class WareHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<InfoProduct> InfoProducts{ get; set; }
    }
}
