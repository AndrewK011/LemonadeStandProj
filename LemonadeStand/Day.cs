using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        Customer customer;
        Random rng = new Random();
        public double demand;

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();          
        }      

        public double GetDemand(Weather weather)
        {
            switch (weather.condition)
            {
                case "rainy":
                    demand += 5.0;
                    break;
                case "overcast":
                    demand += 10.0;
                    break;
                case "cloudy":
                    demand += 15.0;
                    break;
                case "sunny and clear":
                    demand += 20.0;
                    break;          
                default:
                    break;
            }

            demand += (weather.temperature - 45);
            return demand;
        }

        public void CreateDay()
        {          
            double demand = GetDemand(weather);
            for (int i = 0; i < demand; i++)
            {

                customer = new Customer();
                customer.SetChanceToBuy(rng);
                customers.Add(customer);
            }
        }

        public void Forecast()
        {
            Console.WriteLine($"Tomorrow's weather forecast is {weather.predictedForecast}");
        }

        public void BeginDay(Player player)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].chanceToBuy >= player.recipe.pricePerCup)
                {
                    MakePurchase(player);
                }
            }
        }

        public void MakePurchase(Player player)
        {
            for(int i = 0; i < player.recipe.amountOfIceCubes; i++)
            {
                player.inventory.iceCubes.RemoveAt(i);
            }
            
        }

        public bool IsSoldOut()
        {

        }
    }
}
