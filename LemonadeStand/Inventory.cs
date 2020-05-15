using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemons;// = new List<Lemon>();
        public List<IceCube> iceCubes;// = new List<IceCube>();
        public List<Cup> cups;// = new List<Cup>();
        public List<SugarCube> sugarCubes;// = new List<SugarCube>();
        public Cup cup = new Cup();
        public SugarCube sugar = new SugarCube();
        public Lemon lemon = new Lemon();
        public IceCube ice = new IceCube();

        public Inventory()
        {

        }

        public void AddCupToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                cups.Add(cup);
            }
        }
        
        public void AddSugarToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                sugarCubes.Add(sugar);
            }
        }
        
        public void AddLemonToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                lemons.Add(lemon);
            }
        }
        
        public void AddIceToInventory(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                iceCubes.Add(ice);
            }
        }





    }
}
