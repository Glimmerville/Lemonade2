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
            //run greeting, set up conditions in Player, I think.
            Greeting();
            double cash = 0;
            Console.WriteLine("What is your name?");
            string player = Console.ReadLine();
            Lemonstuff currentLemonade = new Lemonstuff(0);
            //currentLemonade.LemonStatus(); //All the amount tracking is done in Lemonstuff. It works!
            Console.WriteLine("Let's make some lemonade to start the game.");
            currentLemonade.MakeLemonade();
            //I think this (weather time "morning" (get weather) get customer)
            //then loop to weather time "noon" (get weather) (get customer)
            //then afternoon
            //could be a "these three loops happen every day"
            //then set the day counter up by one
            //you have X days to play the game.
            WeatherTime today = new WeatherTime("morning");
            Console.WriteLine("Here comes a new customer!");
            Customer Cust = new Customer();
            Cust.SetThirst();
            Console.WriteLine("Customer is " + Cust.CustomerThirst);

        }
    }
}
