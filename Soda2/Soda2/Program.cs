using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VendingMachine machine = new VendingMachine();
            //machine.FillRegisterPenny();
            //Customer customer = new Customer();
            //List<Coin> payment = machine.customer.BuyGrapeSoda();
            //machine.AcceptPayment(payment);
            LunchRoom room = new LunchRoom();
            room.GetDisplay();
        }
    }
}
