using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {      
        Day day;
        Store store;
        Player playerOne;
        List<Day> days;
        int currentDay;      

        public Game()
        {
            day = new Day();
            store = new Store();
            playerOne = new Player();
            days = new List<Day>();
            currentDay = 1;
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to your Lemonade Stand!");
            HowManyDays();
            DayLoop();
        }

        public void DayLoop()
        {
            day.CreateDay(playerOne);
            Console.WriteLine($"Day {currentDay}\n");
            days[currentDay].Forecast();
            store.GoToStore(playerOne);
            
            
        }


        public void HowManyDays()
        {
            Console.WriteLine("How many days would you like to play? 7/14/30");
            string dayChoice = Console.ReadLine();
            switch (dayChoice)
            {
                case "7":
                    GenerateDaysList(7);
                    break;
                case "14":
                    GenerateDaysList(14);
                    break;
                case "30":
                    GenerateDaysList(30);
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    HowManyDays();
                    break;
            }
        }

        public void GenerateDaysList(int numberOfDays)
        {
            for (int i = 1; i <= numberOfDays; i++)
            {
                days.Add(day);
            }
        }

    }
}
