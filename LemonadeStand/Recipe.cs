using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            
        }

        public void SetRecipe()
        {
            SetLemons();
            SetSugar();
            SetIce();
            SetPrice();
        }

        public void SetLemons()
        {
            Console.WriteLine("How many lemons do you want per pitcher?");
            amountOfLemons = UserInterface.HowMany();
        }

        public void SetSugar()
        {
            Console.WriteLine("How many sugar cubes do you want per pitcher?");
            amountOfSugarCubes = UserInterface.HowMany();
        }

        public void SetIce()
        {
            Console.WriteLine("How many ice cubes do you want per pitcher?");
            amountOfIceCubes = UserInterface.HowMany();
        }

        public void SetPrice()
        {
            Console.WriteLine("How much do you want to charge per cup?");
            pricePerCup = UserInterface.HowMuch();
        }

        


    } 
}
