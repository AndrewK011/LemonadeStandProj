using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCube : Item
    {
        public IceCube()
        {
            name = "ice cube";
        }

        public void Melt(List<IceCube> cubes)
        {                  
            cubes.Clear();
            Console.WriteLine("All your ice cubes have melted.");
            
        }
    }
}
