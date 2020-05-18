using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        public void FillPitcher()
        {
            AddLemonsToPitcher();
            AddSugarToPitcher();
            AddIceToPitcher();
            UseCup();

        }
        public void AddLemonsToPitcher()
        {
            for (int i = 0; i < recipe.amountOfLemons; i++)
            {
                inventory.lemons.RemoveAt(0);
            }
        }
        public void AddSugarToPitcher()
        {
            for (int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                inventory.sugarCubes.RemoveAt(0);
            }
        }
        public void AddIceToPitcher()
        {
            for (int i = 0; i < recipe.amountOfIceCubes; i++)
            {
                inventory.iceCubes.RemoveAt(0);
            }
        }
        public void UseCup()
        {
            inventory.cups.RemoveAt(0);
        }
    }
}
