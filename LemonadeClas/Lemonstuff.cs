using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Lemonstuff
    {
        //fields props whatever
       public int lemons { get; set; } = 6;
       public int water { get; set; } = 12;
       public int sugar { get; set; } = 3;
       public int ice { get; set;  } = 12;
       public int lemonade { get; set; } = 0;
       
       //method to access them - or two or three
       //ok "make lemonade"
       //if these = the values they start at,
       //lemonade = 14, and these = 0
       //that is a good start
       //also "sell lemonade" = lemonade-- maybe
       public void LemonStatus()
        {
            Console.WriteLine("You have {0} cups of lemonade.\n", lemonade);
            {
                if (lemonade == 14)
                {
                    Console.WriteLine("You have a brimming full pitcher of lemonade - 14 cups.\n");
                }
                else if (lemonade > 5)
                {
                    Console.WriteLine("Keep an eye on it and don't let it get to zero.\n");
                }
                else if (lemonade > 2 && lemonade < 5)
                {
                    Console.WriteLine("You should think about making more.\n");
                }
                else if (lemonade >0 && lemonade < 2)
                {
                    Console.WriteLine("You are almost out of lemonade!\n");
                }
                else
                {
                    Console.WriteLine("You need to make some lemonade!\n");
                }
            }
        }
       public void MakeLemonade()
        {
            if (lemons == 6 && water == 12 & sugar == 3 && ice == 12)
            {
                Console.WriteLine("You now have a pitcher of Lemonade (14 cups).\n");
                lemonade = 14;
                Console.WriteLine("You have used up 6 lemons, 12 cups of water, 3 cups of sugar, and 12 ice cubes.\n");
            }
        }
    
        //constructor...
        public Lemonstuff(int lemonadeNow)
        {
            this.lemonade = lemonadeNow;
        }
    }
}
