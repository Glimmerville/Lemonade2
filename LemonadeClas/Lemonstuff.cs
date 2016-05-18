using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Lemonstuff
    {
        //fields props
       public int lemons { get; set; } = 6;
       public int water { get; set; } = 12;
       public int sugar { get; set; } = 3;
       public int ice { get; set;  } = 12;
       public int lemonade { get; set; } = 0;
       public int makeLemonadeCount { get; set; } = 0;
       
       //method
       public void LemonStatus()
        {
            Console.WriteLine("You have {0} cups of lemonade.", lemonade);
            {
                if (lemonade == 14)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You have a brimming full pitcher of lemonade - 14 cups.");
                    Console.ResetColor();
                }
                else if (lemonade > 5 && lemonade < 14)
                {
                    //Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //Console.WriteLine("Keep an eye on it and don't let it get to zero.");
                    //Console.ResetColor();
                    //I took this out because it was filling up the screen
                }
                else if (lemonade > 2 && lemonade <= 5)
                {
                   // Console.ForegroundColor = ConsoleColor.DarkYellow;
                   // Console.WriteLine("You should think about making more.");
                   // Console.ResetColor();
                   //I took this out because it was distracting 
                }
                else if (lemonade > 0 && lemonade <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You are almost out of lemonade!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must make lemonade right now!");
                    Console.ResetColor();
                    MakeLemonade();
                    makeLemonadeCount = makeLemonadeCount + 1;
                }
            }
        }
       public void MakeLemonade()
        {
            if (lemons == 6 && water == 12 & sugar == 3 && ice == 12)
            {
                Console.WriteLine("You have a pitcher of lemonade (14 cups).\n");
                lemonade = 14;
               // Console.WriteLine("You have used up 6 lemons, 12 cups of water, \n3 cups of sugar, and 12 ice cubes.\n");
                makeLemonadeCount = makeLemonadeCount + 1;
            }
        }
        public int ReturnLemonadeCount()
        {
            return makeLemonadeCount;
        }
    
        //constructor
        public Lemonstuff(int lemonadeNow)
        {
            this.lemonade = lemonadeNow;
        }
    }
}
