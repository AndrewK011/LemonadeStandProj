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

        public void Spoilage(List<Lemon> lemons)
        {
            
        }
    }
}
