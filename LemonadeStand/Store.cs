using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double pricePerLemon;
        double pricePerSugarCube;
        double pricePerIceCube;
        double pricePerCup;
        int quantity = 0;

        public Store()
        {
            pricePerCup = 0.03;
            pricePerLemon = 0.09;
            pricePerSugarCube = 0.07;
            pricePerIceCube = 0.01;
        }

        public void GoToStore(Player player)
        {           
            CupStore(player);           
            LemonStore(player);           
            SugarStore(player);
            IceStore(player);           

        }

        public void CupStore(Player player)
        {
            Console.WriteLine($"You have {player.inventory.cups.Count} cups.\nHow many do you want to buy for {pricePerCup} each?");
            quantity = UserInterface.HowMany();
            quantity = player.wallet.PayForItem(quantity, pricePerCup);
            player.inventory.AddCupToInventory(quantity);
        }
        public void LemonStore(Player player)
        {
            Console.WriteLine($"You have {player.inventory.lemons.Count} lemons.\nHow many do you want to buy for {pricePerLemon} each?");
            quantity = UserInterface.HowMany();
            quantity = player.wallet.PayForItem(quantity, pricePerLemon);
            player.inventory.AddLemonToInventory(quantity);
        }
        public void SugarStore(Player player)
        {
            Console.WriteLine($"You have {player.inventory.sugarCubes.Count} sugar cubes.\nHow many do you want to buy for {pricePerSugarCube} each?");
            quantity = UserInterface.HowMany();
            quantity = player.wallet.PayForItem(quantity, pricePerSugarCube);
            player.inventory.AddSugarToInventory(quantity);
        }
        public void IceStore(Player player)
        {
            Console.WriteLine($"You have {player.inventory.iceCubes.Count} ice cubes.\nHow many do you want to buy for {pricePerIceCube} each?");
            quantity = UserInterface.HowMany();
            quantity = player.wallet.PayForItem(quantity, pricePerIceCube);
            player.inventory.AddIceToInventory(quantity);
        }
    }
}
