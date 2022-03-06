using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SHOP.Models
{
    internal class Product
    {
        public int Id { get; set; }    
        public string? Name { get; set; } 
        public int? Description { get; set; } 
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Warehouse { get; set; }
        public int Count { get; set; }
    }
}
