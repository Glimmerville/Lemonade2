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
            Console.WriteLine("o ....oooo0000OO0000oooo.... o\n");
            Console.WriteLine("o Welcome to LEMONADE STAND! o\n");
            Console.WriteLine("o ....oooo0000OO0000oooo.... o\n\n");
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
            Player player = new Player(playerName, 5);
            Lemonstuff currentLemonade = new Lemonstuff(0);
            //currentLemonade.LemonStatus(); //All the amount tracking is done in Lemonstuff. It works!
           // Console.WriteLine("You start with $5, which will cover the cost of your first pitcher of lemonade.");
            Console.WriteLine("Let's make some lemonade to start the game. \nWe'll subtract the cost at the end of the day.");
            while (dayCount < 7)
            { 
            currentLemonade.MakeLemonade();
            Console.ReadKey();
            Console.Clear();
            WeatherTime today = new WeatherTime(0);//when should this update?
                while (timeIncrement < 21)
                {
                    timeIncrement = timeIncrement + 1;   
                    if (timeIncrement % 5 == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        today.timeOfDayNum = today.timeOfDayNum + 1;
                        today.WeatherCall();
                        Console.ResetColor();
                        currentLemonade.LemonStatus();
                    }
                    else if (timeIncrement == 21)
                    {
                        //currentLemonade.ReturnLemonadeCount();
                        player.cash = player.cash - (currentLemonade.ReturnLemonadeCount() * 5);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("            Day {0} is over!               ", dayCount);
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        dayCount = dayCount + 1;
                        Console.WriteLine("You sold {0} cups of lemonade!", soldCount);
                        Console.WriteLine("After removing $5 ingredients per pitcher, your total cash is ${0}!", player.cash);
                        Console.ResetColor();
                        Console.ReadKey();
                        dayCount = dayCount++;
                        Console.WriteLine("Ready for a new day?");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else {
                        custCount = custCount + 1;
                        Console.WriteLine("\nHere comes a new customer!");
                        Console.WriteLine("This is your customer #{0} of the day.", custCount);
                        Customer Cust = new Customer();
                        Console.ReadKey();
                        Cust.SetThirst();
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
                        }
                    }
                }
            }
        }
    }
}
