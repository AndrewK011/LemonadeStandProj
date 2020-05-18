using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions = new List<string>(){ "rainy", "sunny and clear", "cloudy", "overcast" };
        public string predictedForecast;
        Random rng = new Random();
        

        public Weather()
        {
            condition = weatherConditions[rng.Next(0, 4)];
            temperature = rng.Next(50, 102);
            predictedForecast = condition + " at " + temperature.ToString() + " degress Fahrenheit.";
        }
    }
}
