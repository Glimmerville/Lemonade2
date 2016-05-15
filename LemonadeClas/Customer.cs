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
        private string customerCold;
        public string CustomerCold { get; set; }
        //set the customer thirst 
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

        //Changing this to actually mean 'willing to buy at $ price' but still basically 'thirsty'
        public void SetCold()
        {
            Random cold = new Random();
            if (cold.Next(0, 100) % 2 == 0)
            {
                CustomerCold = "Cold";
            }
            else
            {
                CustomerCold = "Warm";
            }
        }
        public Customer()
        {
            this.CustomerThirst = customerThirst;
            this.CustomerCold = customerCold;
        }
    }
}

