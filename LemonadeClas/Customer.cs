using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Customer
    {
        private string customerThirst; 
        public string CustomerThirst { get; set; }
        //set the customer thirst (it works)
        public void SetThirst()
        {
            Random thirst = new Random();
            if (thirst.Next(0, 100) % 2 == 0)
            {
               CustomerThirst = "Happy";
            }
            else
            {
                CustomerThirst = "Not Happy";
            }
        }
        public Customer()
        {
            this.CustomerThirst = customerThirst;
        }
           //Changing this to actually mean 'willing to buy at $ price' but still basically 'thirsty'
    }
}
