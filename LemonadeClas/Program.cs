﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Program
    {
        public static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("          .oo00000oo. ");
            Console.WriteLine("       .oo000000000O0oo. ");
            Console.WriteLine("   ...oooo0000000000OOooo... ");
            Console.WriteLine("   ...oooo00000000000oOoo... ");
            Console.WriteLine("       .oo00000000000oo. ");
            Console.WriteLine("          .oo00000oo. \n");
            Console.WriteLine("o Welcome to LEMONADE STAND! o\n");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            int dayCount = 1;
            int timeIncrement = 0;
            int custCount = 0;
            int soldCount = 0;
            Greeting();

            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, 3);
            Lemonstuff currentLemonade = new Lemonstuff(0);
            //currentLemonade.LemonStatus(); //TESTING
            Console.WriteLine("You start with $3, which will cover the cost of your first pitcher of lemonade.");
            Console.WriteLine("Let's make some lemonade to start the game. \nWe'll subtract the cost at the end of the day.");
            while (dayCount < 7)
            {
                currentLemonade.MakeLemonade();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                WeatherTime today = new WeatherTime(0);
                //Console.WriteLine(currentLemonade.makeLemonadeCount); TESTING
                while (timeIncrement < 21)
                {
                    timeIncrement = timeIncrement + 1;
                    if (timeIncrement % 5 == 0)
                    {
                        Console.Clear();
                        today.timeOfDayNum = today.timeOfDayNum + 1;
                        today.WeatherCall();
                        currentLemonade.LemonStatus();
                    }
                    else if (timeIncrement == 21)
                    {
                        //currentLemonade.ReturnLemonadeCount();
                        player.cash = player.cash - (currentLemonade.ReturnLemonadeCount() * 3);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("            Day {0} is over!               ", dayCount);
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        dayCount = dayCount + 1;
                        Console.WriteLine("You sold {0} cups of lemonade!\nBut the leftover lemonade can't be saved. Yuck.", soldCount);
                        Console.WriteLine("After removing $3 ingredients per pitcher, your total cash is ${0}!", player.cash);
                        Console.ResetColor();
                        Console.ReadKey();
                        dayCount = dayCount++;
                        Console.WriteLine("Ready for a new day?");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else {
                        custCount = custCount + 1;
                        Customer Cust = new Customer();
                        Cust.SetThirst();
                        if (today.weatherNow != "sunny" && Cust.CustomerCold != "warm")
                            {
                            Console.WriteLine("No one comes for awhile because the weather isn't nice enough.");
                            timeIncrement = timeIncrement + 1;
                            custCount = custCount - 1;
                            today.WeatherCall();
                            Console.ReadKey();
                            }
                        else {
                            Console.WriteLine("\nHere comes a new customer!");
                            Console.WriteLine("This is your customer #{0} of the day.", custCount);
                            //Customer Cust = new Customer();
                            //Console.ReadKey();
                            //Cust.SetThirst();
                            Console.WriteLine("Do you want to charge $1 or $2 for lemonade?");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Customer is ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Cust.CustomerThirst + ". ");
                            Console.ResetColor();
                            if (Cust.CustomerThirst == "Not Happy" && price == 2)
                            {
                                Console.WriteLine("You try to sell the lemonade, \nbut the customer doesn't want to pay " + price + "!");
                                Console.WriteLine("Better luck next time?");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (Cust.CustomerThirst == "Not Happy" && price == 1)
                            {
                                Console.WriteLine("But the customer changes his mind because \nyour lemonade is so reasonably priced!");
                                currentLemonade.lemonade = currentLemonade.lemonade - 1;
                                player.cash = player.cash + price;
                                soldCount = soldCount + 1;
                                Console.WriteLine("You sell a cup of lemonade to the thirsty customer.");
                                currentLemonade.LemonStatus();
                                Console.WriteLine("You now have ${0}!", player.cash);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                currentLemonade.lemonade = currentLemonade.lemonade - 1;
                                player.cash = player.cash + price;
                                soldCount = soldCount + 1;
                                Console.WriteLine("You sell a cup of lemonade to the thirsty customer.");
                                currentLemonade.LemonStatus();
                                Console.WriteLine("You now have ${0}!", player.cash);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}
