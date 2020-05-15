using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public string name;
        public double demand;
        public double chanceToBuy;

        public Customer()
        {

        }

        public void SetDemand(Weather weather)
        {
            switch(weather.condition)
            {
                case "rainy":
                    break;
                case"overcast":
                    demand += 20.0;
                    break;
                case"sunny and clear":
                    demand += 50.0;
                    break;
                case"cloudy":
                    demand += 30.0;
                    break;
                default:
                    break;
            }
        }

        public void SetChanceToBuy(double demand, double pricePerCup)
        {

        }
    }
}
