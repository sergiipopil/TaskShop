using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShop.Classes
{
    public class ProductManager
    {
        public List<Product> ProductList { get; set; }
        public List<Product> GetProductsList()
        {
            return ProductList;
        }
        public void AddProduct(Product product)
        {
            int id = ProductList.Max(x => x.Id);
            product.Id = ++id;
            ProductList.Add(product);
        }
        public void DeleteProduct(int productId)
        {
            if (ProductList != null && ProductList.Count > 0)
            {
                Product deletedProduct = ProductList.FirstOrDefault(x => x.Id == productId);
                if (deletedProduct != null)
                {
                    ProductList.Remove(deletedProduct);
                }
            }
        }
    }
}
