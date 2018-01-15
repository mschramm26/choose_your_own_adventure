using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Mainland
    {
        // member variables
        string userInput;

        // constructor
        public Mainland()
        {

        }

        // member methods
        public string EscapeFromPirates()
        {
            Console.WriteLine("You hide until the pirates sail away without you. The cannibals try to eat you, but you talk them out of it. They help you build a boat, and you go back to the mainland.");
            Console.WriteLine("Enter 1 to get on a plane to fly back home.");
            Console.WriteLine("Enter 2 to rent a car and drive home.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public void PlaneCrashes()
        {

            Console.WriteLine("The plane crashes and everyone dies.");
            Console.WriteLine("You lose. Game over.");
        }

        public void DriveCar()
        {
            Console.WriteLine("You drive back home, go to bed, and live happily ever after.");
            Console.WriteLine("You win! Game over.");
        }

    }
}
