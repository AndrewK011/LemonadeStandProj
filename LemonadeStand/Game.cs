using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player;
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
        }
    }
}
