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
        List<string> weatherConditions = new List<string>(){ "Rainy", "Sunny and Clear", "Cloudy", "Overcast" };
        public string predictedForecast;
        Random rng = new Random();
        

        public Weather()
        {
            condition = weatherConditions[rng.Next(0, 5)];
            temperature = rng.Next(50, 102);
        }
    }
}
