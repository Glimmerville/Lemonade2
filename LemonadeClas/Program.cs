using System;
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

            Console.WriteLine("o ....oooo0000OO0000oooo.... o\n");
            Console.WriteLine("o Welcome to LEMONADE STAND! o\n");
            Console.WriteLine("o ....oooo0000OO0000oooo.... o\n\n");
        }
        static void Main(string[] args)
        {
            int dayCount = 0;
            int timeIncrement = 0;
            int custCount = 1;
            //run greeting, set up conditions in Player, I think.
            Greeting();
            double cash = 0;
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Lemonstuff currentLemonade = new Lemonstuff(0);
            //currentLemonade.LemonStatus(); //All the amount tracking is done in Lemonstuff. It works!
            Console.WriteLine("Let's make some lemonade to start the game.");
            currentLemonade.MakeLemonade();
            Console.ReadKey();
            Console.Clear();
            //I think this (weather time "morning" (get weather) get customer)
            //then loop to weather time "noon" (get weather) (get customer)
            //then afternoon
            //could be a "these three loops happen every day"
            //then set the day counter up by one
            //you have X days to play the game.
            //like one week to get enough money for a bike/birthday present/something
            WeatherTime today = new WeatherTime(0);//when should this update?
            while (timeIncrement < 12)
                {
                Console.WriteLine("Here comes a new customer!");
                timeIncrement = timeIncrement + 1;
                if (timeIncrement % 3 == 0)
                {
                    today.timeOfDayNum = today.timeOfDayNum +1;
                    today.WeatherCall();
                    //Console.ReadKey();
                }
                else if (timeIncrement == 10)
                {
                    Console.WriteLine("The day is over!");
                    dayCount = dayCount + 1;
                    Console.WriteLine("Your total cash is ${0}", cash);
                    Console.ReadKey();
                }
                Customer Cust = new Customer();
                Console.ReadKey();
                Cust.SetThirst();
                Console.WriteLine("Customer is " + Cust.CustomerThirst);
                if (Cust.CustomerThirst == "Not Thirsty")
                {
                    Console.WriteLine("You try to sell the lemonade, but the customer doesn't want any.");
                }
                else
                {
                    currentLemonade.lemonade = currentLemonade.lemonade--;
                    cash = cash + 1;
                    Console.WriteLine("You sell a cup of lemonade to the thirsty customer.");
                    Console.WriteLine("You now have ${0}! Sweet!", cash);
                    Console.ReadKey();
                }

            }
        }
    }
}
