using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Island
    {

        // member variables
        string userInput;

        // constructor
        public Island()
        {

        }

        // member methods

        public string PiratesCome()
        {
            Console.WriteLine("While you are waiting for help, pirates arrive and take you prisoner. They take you to an island, populated by angry cannibals, where they are searching for treasure. You have a chance to escape when the pirates look away for a moment.");
            Console.WriteLine("Enter 1 to escape from the pirates by hiding on the island.");
            Console.WriteLine("Enter 2 to go back to the ship with the pirates.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public void StayWithPirates()
        {
            Console.WriteLine("You go back to the ship with the pirates and sail away. Later, they make you walk the plank.");
            Console.WriteLine("You lose. Game over.");
        }

        public void SwimToIslandAndGetEaten()
        {
            Console.WriteLine("To avoid the sharks, you swim to the island of cannibals. When you reach the shore, the cannibals attack and eat you.");
            Console.WriteLine("You lose. Game over.");
        }

    }
}
