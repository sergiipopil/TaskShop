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
        public void ShowProductsList()
        {
            foreach (var item in ProductList)
            {
                Console.WriteLine($"ID: {item.Id}\tTitle: {item.Title}\tCount: {item.Count}\tPricePerKg: {item.PricePerKg}");
            }
            Console.WriteLine();
        }
        public void AddNewProduct(Product product)
        {
            int id = ProductList.Max(x => x.Id);
            product.Id = ++id;
            ProductList.Add(product);
        }
        public void AddExistProduct(Product product)
        {
            if (ProductList != null && ProductList.Count > 0)
            {
                Product productExist = ProductList.FirstOrDefault(x => x.Id == product.Id);
                if (productExist != null)
                {
                    productExist.Count = product.Count;
                    productExist.PricePerKg = product.PricePerKg;
                    productExist.Title = product.Title;
                }
            }
        }
        public void SoldProduct(int productId, int productCount)
        {
            if (ProductList != null && ProductList.Count > 0)
            {
                Product productExist = ProductList.FirstOrDefault(x => x.Id == productId);
                if (productExist != null)
                {
                    //Check if we have count of products which want buy
                    if (productExist.Count > productCount)
                    {
                        productExist.Count -= productCount;
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, but this quantity of {productExist.Title} is not available at the moment.\n" +
                            $"Available only {productExist.Count}\n");
                    }
                }
            }
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
