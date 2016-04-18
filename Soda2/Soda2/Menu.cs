using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda2
{
    public class Menu
    {
        VendingMachine machine = new VendingMachine();
        public void DisplayMenu()
        {
            Console.WriteLine("VENDING MACHINE");
            Console.WriteLine("1 Grape: {0:C}", machine.grape);
            Console.WriteLine("2 Orange: {0:C}", machine.orange);
            Console.WriteLine("3 Meat: {0:C}", machine.meat);
            Console.WriteLine("4 Lemon: {0:C}", machine.lemon);
            Console.WriteLine("5 Strawberry: {0:C}", machine.strawberry);
            Console.WriteLine("6 Exit");
            Console.WriteLine("Which drink would you like to purchase?");

            bool exit = false;
            int choice = Convert.ToInt32(Console.ReadLine());
            while (!exit)
            {
                switch (choice)
                {
                    case 1:
                       // machine.customer.TypeOfPayment();
                        // machine.AddPennyToBank();
                        //    grape();
                        machine.customer.BuyGrapeSoda();
                        break;
                    //case 2:
                    //    orange();
                    //    break;
                    //case 3:
                    //    meat();
                    //    break;
                    case 4:
                        OutOfStock();
                        break;
                    case 5:
                        OutOfStock();
                        break;
                    case 6:
                        GoodBye();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice please...");
                        DisplayMenu();
                        break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void OutOfStock()
        {
            Console.WriteLine("Sorry, temporarily out of this item");
            Console.ReadKey();
            DisplayMenu();
        }
        public void GoodBye()
        {
            Console.WriteLine("GoodBye");
            Environment.Exit(0);
        }
    }
}
