using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        public Lemon()
        {
            name = "lemon";
        }

        public void Spoilage(List<Lemon> lemons, Random rng)
        {
            foreach(Lemon lemon in lemons)
            if(rng.Next(0,21) == 0)
            {
                lemons.RemoveAt(0);
            }
        }
    }
}
