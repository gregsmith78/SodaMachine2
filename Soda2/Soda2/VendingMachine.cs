using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda2
{
    class VendingMachine
    {
        public decimal grape = .60M;
        public decimal orange = .35M;
        public decimal meat = .06M;
        public decimal lemon = .25M;
        public decimal strawberry = .45M;
        public List<Coin> coinList;
        public List<Soda> sodaList;
        Penny penny;

        public Customer customer = new Customer();
        public double register;

        public VendingMachine()
        {
            penny = new Penny();
            coinList = new List<Coin>();
            sodaList = new List<Soda>();
            register = 0; 
        }
        public double FillRegisterPenny()
        {
        for(int amount = 0; amount <= 50; amount++)
        {
               // coinList.Add(penny);
                register += penny.Price;
               
        }
            return register;
        }
        

        public void AcceptPayment(List<Coin> coins) 
        {
            coinList.AddRange(coins);
        }
    }
}
