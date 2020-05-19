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
        public bool inventoryShortage;
        public double totalGross;
        public int saleCount;
        Random rng = new Random();

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            inventoryShortage = false;
        }

        //Need to fix
        public void FillPitcher()
        {
            inventoryShortage = CheckInventoryShortage();
            if (inventoryShortage == false)
            {
                AddLemonsToPitcher();
                AddSugarToPitcher();
                pitcher.cupsLeftInPitcher += 15;
            }
        }

        public void ServeCup()
        {
                AddIceToCup();
                UseCup();
                pitcher.cupsLeftInPitcher --;             

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
        public void AddIceToCup()
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

        public bool CheckInventoryShortage()
        {
            if (recipe.amountOfLemons > inventory.lemons.Count || recipe.amountOfSugarCubes > inventory.sugarCubes.Count 
                || recipe.amountOfIceCubes > inventory.iceCubes.Count || inventory.cups.Count == 0)
            {            
                return true;
            }

            else
            {
                return false;
            }
        }

        public void MakeSale()
        {
            
            wallet.Money += recipe.pricePerCup;
            saleCount++;
            totalGross += recipe.pricePerCup;
        }

        public void DisplayProfits()
        {
            double totalProfit = totalGross - wallet.totalPriceForGame;
            Console.WriteLine($"\nYou sold {saleCount} cups.\nYou spent a total of {wallet.totalPriceForGame}, made a total of {totalGross}, for a total profit of {totalProfit}");
        }

        public void Upkeep()
        {
            inventory.ice.Melt(inventory.iceCubes);
            inventory.lemon.Spoilage(inventory.lemons, rng);
            saleCount = 0;

        }

    }
}
