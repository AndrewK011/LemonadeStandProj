using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        public Cup cup;
        public SugarCube sugar;
        public Lemon lemon;
        public IceCube ice;
        public Random rng = new Random();

        public Inventory()
        {
            cup = new Cup();
            sugar = new SugarCube();
            lemon = new Lemon();
            ice = new IceCube();
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
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
