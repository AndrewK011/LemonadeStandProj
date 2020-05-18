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
        public double chanceToBuy;
        

        public Customer()
        {
            chanceToBuy = 0;
        }

        

        public void SetChanceToBuy(Random rng)
        {
            chanceToBuy = rng.NextDouble();
        }
    }
}
