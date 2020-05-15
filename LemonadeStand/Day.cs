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
        Customer customer = new Customer();

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            customer.GetDemand(weather); 
        }

        public void AddCustomers(double demand, Player player)
        {
            for (int i = 0; i < demand; i++)
            {
                
                customers.Add(customer);
            }
        }

        public void CreateDay(Player player)
        {
            double demand = customer.GetDemand(weather);
            for (int i = 0; i < demand; i++)
            {
                customer.SetChanceToBuy(demand, player.recipe.pricePerCup);
                customers.Add(customer);
            }
        }
    }
}
