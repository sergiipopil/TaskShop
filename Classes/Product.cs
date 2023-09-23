using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShop.Classes
{
    public class Product : ProductManager
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public decimal PricePerKg { get; set; }
        
        public Product(List<Product> list)
        {
            ProductList = list;
        }
        public Product()
        {
        }

        
    }
}
