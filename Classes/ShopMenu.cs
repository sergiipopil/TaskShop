using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShop.Enums;

namespace TaskShop.Classes
{
    public class ShopMenu
    {
        public Product product = new Product();
        public ShopMenu()
        {
            InitProductList();
            MainMenu();
        }
        private void InitProductList()
        {
            product.ProductList = new List<Product>()
            {
                new Product() { Id = 1, Title = "Bread", Count = 25, PricePerKg = 25.3m },
                new Product() { Id = 2, Title = "Milk", Count = 30, PricePerKg = 52.5m },
                new Product() { Id = 3, Title = "Cheese", Count = 45, PricePerKg = 247.8m },
                new Product() { Id = 4, Title = "Sausage", Count = 20, PricePerKg = 195 },
                new Product() { Id = 5, Title = "Potato", Count = 120, PricePerKg = 35 }
            };
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("You are welcome to Codozavrs shop\n");
            Console.WriteLine("Main menu:\n\n" +
                "Press 0 - EXIT\n" +
                "Press 1 - seller mode\n" +
                "Press 2 - buyer mode\n");
            Console.Write("Select menu item:");
            bool isCorrectMode = Enum.TryParse(Console.ReadLine(), out AppMode modeType);

            if (!isCorrectMode && !Enum.IsDefined(typeof(AppMode), modeType))
            {
                MainMenu();
            }
            else
            {
                switch (modeType)
                {
                    case AppMode.Exit:
                        Console.WriteLine("Thanks for visit us!");
                        Environment.Exit(0);
                        break;
                    case AppMode.Seller:
                        Console.Clear();
                        SellerMenu();
                        break;
                    case AppMode.Buyer:
                        Console.Clear();
                        BuyerMenu();
                        break;
                }
            }
        }
        public void SellerMenu()
        {
            Console.WriteLine("It`s seller mode");
            Console.WriteLine("Seller menu:\n\n" +
                "Press 0 - Return to Main Menu\n" +
                "Press 1 - sold item\n" +
                "Press 2 - add item\n" +
                "Press 3 - delete item\n" +
                "Press 4 - get all items\n" +
                "Press 5 - get item details\n");
            Console.Write("Select menu item:");
            bool isCorrectMode = Enum.TryParse(Console.ReadLine(), out SellerMode sellerModeType);

            if (!isCorrectMode && !Enum.IsDefined(typeof(SellerMode), sellerModeType))
            {
                Console.Clear();
                SellerMenu();
            }
            else
            {
                switch (sellerModeType)
                {
                    case SellerMode.MainMenu:
                        MainMenu();
                        break;
                    case SellerMode.AddItem:
                        //todo
                        Console.WriteLine("Add item");
                        break;
                    case SellerMode.DeleteItem:
                        //todo
                        Console.WriteLine("Delete item");
                        break;
                    case SellerMode.SoldItem:
                        //todo
                        Console.WriteLine("Sold item");
                        break;
                    case SellerMode.GetAllItems:
                        //todo
                        product.ShowProductsList();                        
                        SellerMenu();
                        break;
                    case SellerMode.ItemDetails:
                        //todo
                        Console.WriteLine("Get item details");
                        break;
                }
            }
        }
        public void BuyerMenu()
        {
            Console.WriteLine("It`s buyer mode");
            Console.WriteLine("Buyer menu:\n\n" +
                "Press 0 - Return to Main Menu\n" +
                "Press 1 - buy item\n" +
                "Press 2 - return item\n" +
                "Press 3 - get all items\n" +
                "Press 4 - get item detais\n");
            Console.Write("Select menu item:");
            bool isCorrectMode = Enum.TryParse(Console.ReadLine(), out BuyerMode buyerModeType);

            if (!isCorrectMode && !Enum.IsDefined(typeof(BuyerMode), buyerModeType))
            {
                Console.Clear();
                SellerMenu();
            }
            else
            {
                switch (buyerModeType)
                {
                    case BuyerMode.MainMenu:
                        MainMenu();
                        break;
                    case BuyerMode.BuyItem:
                        //todo
                        product.ShowProductsList();
                        Console.Write("Please enter Id of product which you want buy:");
                        bool isCorrectId = int.TryParse(Console.ReadLine(), out int productId);
                        if (isCorrectId)
                        {
                            Console.Write("Enter items or kg do you want buy:");
                            bool isCorrectCount = int.TryParse(Console.ReadLine(), out int productCount);
                            if (isCorrectCount)
                            {
                                product.SoldProduct(productId, productCount);                                
                            }
                        }
                        product.ShowProductsList();
                        Console.WriteLine();
                        break;
                    case BuyerMode.ReturnItem:
                        //todo
                        Console.WriteLine("Return item");
                        break;
                    case BuyerMode.ItemDetails:
                        //todo
                        Console.WriteLine("Item details");
                        break;
                    case BuyerMode.GetAllItems:
                        //todo
                        product.ShowProductsList();                        
                        BuyerMenu();
                        break;
                }
            }
        }
    }
}
