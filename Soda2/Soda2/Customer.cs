using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda2
{
    public class Customer
    {
        public List<Coin> customerCoinsList;
        public List<Soda> soda;
        Penny penny = new Penny();
        Nickel nickel = new Nickel();
        Dime dime = new Dime();
        Quarter quarter = new Quarter();
        Grape grape = new Grape();
        public Customer()
        {

            customerCoinsList = new List<Coin>();
            GeneratePennies(customerCoinsList, 100);
            GenerateNickels(customerCoinsList, 20);
            GenerateDimes(customerCoinsList, 10);
            GenerateQuarters(customerCoinsList, 8);


        }
        public void GererateCustomerMoney()
        {

            customerCoinsList = new List<Coin>();
            GeneratePennies(customerCoinsList, 100);
            GenerateNickels(customerCoinsList, 20);
            GenerateDimes(customerCoinsList, 10);
            GenerateQuarters(customerCoinsList, 8);
        }
        //public void TypeOfPayment()
        //{
        //    Console.WriteLine("Press 1 to pay with a penny.");
        //    Console.WriteLine("Press 2 to pay with a nickel.");
        //    Console.WriteLine("Press 3 to pay with a dime.");
        //    Console.WriteLine("Press 4 to pay with a quarter.");

        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    bool exit = false;
        //    while (!exit)
        //    {
        //        switch (choice)
        //        {
        //            case 1:
        //                DepositPenny(penny);
        //                break;
        //            case 2:
        //                // AddNickelToBank(nickel);
        //                break;
        //            case 3:
        //                // AddDimeToBank(dime);
        //                break;
        //            case 4:
        //                // AddQuarterToBank(quarter);
        //                break;
        //            case 5:
        //                exit = true;
        //                break;
        //            default:
        //                Console.WriteLine("Please select a valid amount...");
        //                //  TypeOfPayment();
        //                break;
        //        }

        //    }

        // }
        public List<Coin> GeneratePennies(List<Coin> coinList, int coinAmount)
        {
            for (int amount = 0; amount < coinAmount; amount++)
            {
                coinList.Add(penny);
            }
            return customerCoinsList;

        }
        public List<Coin> GenerateNickels(List<Coin> coinList, int coinAmount)
        {
            for (int amount = 0; amount < coinAmount; amount++)
            {
                coinList.Add(nickel);
            }
            return customerCoinsList;
        }
        public List<Coin> GenerateDimes(List<Coin> coinList, int coinAmount)
        {
            for (int amount = 0; amount < coinAmount; amount++)
            {
                coinList.Add(dime);
            }
            return customerCoinsList;
        }

        public List<Coin> GenerateQuarters(List<Coin> coinList, int coinAmount)
        {
            for (int amount = 0; amount < coinAmount; amount++)
            {
                coinList.Add(quarter);
            }
            return customerCoinsList;
        }
        public List<Coin> BuyGrapeSoda()
        {
            Console.WriteLine("How would like to pay?");
            Console.WriteLine("Press 1 to pay with a penny.");
            Console.WriteLine("Press 2 to pay with a nickel.");
            Console.WriteLine("Press 3 to pay with a dime.");
            Console.WriteLine("Press 4 to pay with a quarter.");

            int choice = Convert.ToInt32(Console.ReadLine());
            bool exit = false;
            while (!exit)
            {
                switch (choice)
                {
                    case 1:
                        // DepositPenny(penny);
                        break;
                    case 2:
                        // AddNickelToBank(nickel);
                        break;
                    case 3:
                        // AddDimeToBank(dime);
                        break;
                    case 4:
                        // AddQuarterToBank(quarter);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please select a valid amount...");
                        //  TypeOfPayment();
                        break;
                }

            }

            List<Coin> paymentCoins = new List<Coin>();

            for (int amount = 0; amount <= grape.SodaPrice; amount++)
            {
                paymentCoins.Add(penny);
            }
            return paymentCoins;
            //}
            //public double DepositPenny(Penny penny)
            //{
            //    machine.register += penny.Price;
            //    return machine.register;
            //}
            //public double DepositNickel(VendingMachine machine, Nickel nickel)
            //{

            //}

        }
    }
}
