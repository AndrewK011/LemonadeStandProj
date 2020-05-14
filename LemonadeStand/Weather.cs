using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions = new List<string>(){ "Hazy", "Rainy", "Sunny and Clear", "Cloudy" };
        public string predictedForecast;

        public Weather()
        {

        }
    }
}
