using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda2
{
    public class LunchRoom
    {
        VendingMachine machine;
        Customer customer;
        Menu menu;

        public LunchRoom()
        {
            menu = new Menu();
            machine = new VendingMachine();
            customer = new Customer();
        }  
        public void GetDisplay()
        {
            menu.DisplayMenu();
        }
    
    }
}
