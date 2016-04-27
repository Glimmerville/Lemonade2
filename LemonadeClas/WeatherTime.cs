using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class WeatherTime
    {
        public string morning { get; set; } = "nice";
        public string noon { get; set; } = "warm";
        public string afternoon { get; set; } = "cool";
        public string evening { get; set; } = "cool";
        public string weatherNow { get; set; }
        public string tempNow { get; set; }

        string[] weather = { "raining", "sunny", "drizzling", "sunny", "sunny", "sunny", "blazing", "cloudy" };
        string[] temperature = { "cold", "cool", "nice", "warm", "nice", "hot", "warm", "hot" };

        //get a random weather and temp?
        public WeatherTime(string time)
        {
            Random rand = new Random();
            int number = rand.Next(weather.Length);
            weatherNow = weather[number];
            tempNow = temperature[number];
            Console.WriteLine("The weather this {0} is {1} and {2}", time, weatherNow, tempNow);
        }
        
    }
}
