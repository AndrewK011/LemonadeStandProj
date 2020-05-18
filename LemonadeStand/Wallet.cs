using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        double money;
        public double Money;
        public double totalPrice;

        public Wallet()
        {
            money = 20.00;
            Money = money;
        }

        public int PayForItem(int quantity, double pricePerItem)
        {
            int itemsActuallyPurchased = quantity;

            totalPrice = quantity * pricePerItem;
            while (!EnoughMoney(totalPrice))
            {
                totalPrice -= pricePerItem;
                itemsActuallyPurchased--;
            }

            if(totalPrice < 1)
            {
                Console.WriteLine($"You bought {itemsActuallyPurchased} for a total of {totalPrice} cents.");
            }

            else
            {
                Console.WriteLine($"You bought {itemsActuallyPurchased} for a total of {totalPrice} dollars.");
            }

            money -= totalPrice;
            
            DisplayMoney();

            return itemsActuallyPurchased;
        }

        public bool EnoughMoney(double totalPrice)
        {
            if (money >= totalPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayMoney()
        {
            Console.WriteLine($"You have {money} dollars.");
        }
    }
}
