using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Program
    {
        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   .oo00000oo. ");
            Console.WriteLine("                .oo000000000O0oo. ");
            Console.WriteLine("              .oooo0000000000OOooo. ");
            Console.WriteLine("              .oooo00000000000oOoo. ");
            Console.WriteLine("                .oo00000000000oo. ");
            Console.WriteLine("                   .oo00000oo. \n");
            Console.WriteLine(" _     _____  _      ____  _      ____  ____  _____ ");
            Console.WriteLine("/ \\   / __/  / \\__/|/  _ \\/ \\  /|/  _ \\/  _ \\/  __/ ");
            Console.WriteLine("| |   |  \\   | |\\/||| / \\|| |\\ ||| / \\|| | \\||  \\   ");
            Console.WriteLine("| |_/\\|  /_  | |  ||| \\_/|| | \\||| |-||| |_/||  /_ ");
            Console.WriteLine("\\____/\\____\\ \\_/  \\|\\____/\\_/  \\|\\_/ \\|\\____/\\____\\ ");
            Console.WriteLine("  Welcome to LEMONADE STAND!  \n");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            //some initial values
            int dayCount = 1;
            int timeIncrement = 0;
            int custCount = 0;
            int soldCount = 0;
            string yorn = "y";//do you want to play again (begin with y to play at all)
            Greeting();
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, 0);
            Lemonstuff currentLemonade = new Lemonstuff(0);
            Console.WriteLine("The cost of a pitcher of lemonade is $3 - it will come from your profits!");
            while (yorn == "y")//this is not working
            {
                currentLemonade.MakeLemonade();
                player.cash = player.cash - 3;
                AnyKey();
                WeatherTime today = new WeatherTime(0);
                while (timeIncrement < 13)
                {
                    timeIncrement = timeIncrement + 1;
                    if (timeIncrement % 3 == 0)
                    {
                        Console.Clear();
                        today.timeOfDayNum = today.timeOfDayNum + 1;
                        today.WeatherCall();
                        currentLemonade.LemonStatus();
                    }
                   
                    else {
                        custCount = custCount + 1;
                        Customer Cust = new Customer();
                        Cust.SetThirst();
                        if (today.weatherNow != "sunny" && Cust.CustomerCold != "Warm" && today.tempNow == "cold")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("No one comes for awhile because the weather isn't nice enough.");
                            Console.ResetColor();
                            Console.WriteLine("You wait, to see if the weather improves.");
                            timeIncrement = timeIncrement + 1;
                            custCount = custCount - 1;
                            today.weatherNow = "sunny";
                            today.tempNow = "warm";
                            AnyKey();
                        }
                        else if {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Right now the weather is " + today.weatherNow + ".");
                            Console.ResetColor();
                            Console.WriteLine("\nHere comes a new customer!");
                            Console.WriteLine("This is your customer #{0} of the day.", custCount);
                            Console.WriteLine("How much do you want to charge for lemonade?");
                            double price = double.Parse(Console.ReadLine());
                            if (price > 5)
                            {
                                Console.WriteLine("Come on, " + playerName + "! That's a ridiculous price for lemonade!");
                                Cust.CustomerThirst = "Not Happy";
                                Console.WriteLine("The customer leaves in indignation.");
                                custCount = custCount + 1;
                                AnyKey();
                            }
                            else
                            {
                                Console.Write("Customer is ");
                                {
                                    if (Cust.CustomerThirst == "Happy")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                }
                                Console.Write(Cust.CustomerThirst + ". ");
                                Console.ResetColor();
                                if (Cust.CustomerThirst == "Not Happy" && price > 2)
                                {
                                    Console.WriteLine("You try to sell the lemonade, \nbut the customer doesn't want to pay " + price + "!");
                                    Console.WriteLine("Better luck next time?");
                                    AnyKey();
                                }
                                else if (Cust.CustomerThirst == "Not Happy" && price <= 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("But...the customer decided to buy some\n");
                                    Console.ResetColor();
                                    Console.WriteLine("because your lemonade is so reasonably priced!");
                                    currentLemonade.lemonade = currentLemonade.lemonade - 1;
                                    player.cash = player.cash + price;
                                    soldCount = soldCount + 1;
                                    Console.WriteLine("You sell a cup of lemonade to the thirsty customer.");
                                    currentLemonade.LemonStatus();
                                    Console.WriteLine("You now have ${0}!", player.cash);
                                    AnyKey();
                                }
                                else
                                {
                                    currentLemonade.lemonade = currentLemonade.lemonade - 1;
                                    player.cash = player.cash + price;
                                    soldCount = soldCount + 1;
                                    Console.WriteLine("You sell a cup of lemonade to the thirsty customer.");
                                    currentLemonade.LemonStatus();
                                    Console.WriteLine("You now have ${0}!", player.cash);
                                    AnyKey();
                                }
                             else if (timeIncrement == 13)
                            {
                                player.cash = player.cash - ((currentLemonade.ReturnLemonadeCount() - 1) * 3);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("            Day {0} is over!               ", dayCount);
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                dayCount = dayCount + 1;
                                Console.Write(playerName);
                                Console.WriteLine(" sold {0} cups of lemonade!\nBut the leftover lemonade can't be saved. Yuck.", soldCount);
                                Console.WriteLine("After removing $3 ingredients per pitcher, your total cash is ${0}!", player.cash);
                                Console.ResetColor();
                                AnyKey();
                                int goodAnswer = 0;
                                do
                                {
                                    Console.WriteLine("Ready for a new day? (Y/N)");
                                    yorn = Console.ReadLine().ToLower();
                                    if (yorn == "n")
                                    {
                                        Console.WriteLine("Hope you had fun!");
                                        Console.WriteLine("Press any key to exit."); //this works
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                    else if (yorn == "y")
                                    {
                                        timeIncrement = 0;
                                        Console.WriteLine("You answered Yes but I failed anyway.");//this does not work.
                                    }
                                    else
                                    {
                                        Console.WriteLine("What? Please just answer Y or N."); //this works
                                    }
                                } while (goodAnswer == 0);
                                Console.Clear();
                            }
                            }
                        }
                    }
                } 
            } 
          Console.WriteLine("The end?"); //test to see where this shows up
        }
    }
}
