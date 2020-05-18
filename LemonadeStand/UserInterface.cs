using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {      
        public static int HowMany()
        {
            int userInput;
            if(int.TryParse(Console.ReadLine(), out userInput))
            {
                return userInput;
            }

            else
            {
                Console.WriteLine("Invalid input.");
                HowMany();
                
            }

            return userInput;
        }
    }
}
