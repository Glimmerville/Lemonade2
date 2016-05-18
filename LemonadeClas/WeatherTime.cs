using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class WeatherTime
    {

        public string weatherNow { get; set; }
        public string tempNow { get; set; }
        public string[] timeOfDay = { "morning", "noon", "early afternoon", "late afternoon", "evening" };
        public int timeOfDayNum { get; set; }
        public string currTimeWord { get; set; }

        string[] weather = { "raining", "sunny", "drizzling", "sunny", "sunny", "sunny", "cloudy" };
        string[] temperature = { "cold", "nice", "warm", "nice", "hot", "warm", "hot" };

        //get a random weather and temp
        public WeatherTime(int time)
        {
            Random rand = new Random();
            timeOfDayNum = time;
            currTimeWord = timeOfDay[time];
            int number = rand.Next(weather.Length);
            weatherNow = weather[number];
            tempNow = temperature[number];
            Console.WriteLine("The weather this {0} is {1} and the temperature is {2}.", currTimeWord, weatherNow, tempNow);
        }

        public string randomWeather()
        {
            Random rand = new Random();
            int number = rand.Next(weather.Length);
            weatherNow = weather[number];
            return weatherNow;
        }
        public void WeatherCall()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Time is passing! It is now {0} and the weather is {1}.", timeOfDay[timeOfDayNum], randomWeather());
            Console.ResetColor();
        }
        
    }
}
