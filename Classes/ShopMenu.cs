using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShop.Enums;

namespace TaskShop.Classes
{
    public static class ShopMenu
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("You are welcome to Codozavrs shop\n");
            Console.WriteLine("Main menu:\n\n" +
                "Press 1 - seller mode\n" +
                "Press 2 - buyer mode\n" +
                "Press 0 - EXIT\n");
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
        public static void SellerMenu()
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
                        Console.WriteLine("Get all items");
                        break;
                    case SellerMode.ItemDetails:
                        //todo
                        Console.WriteLine("Get item details");
                        break;
                }
            }
        }
        public static void BuyerMenu()
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
                        Console.WriteLine("Buy item");
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
                        Console.WriteLine("Get all items");
                        break;
                }
            }
        }
    }
}
