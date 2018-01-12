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


        // constructor
        public Island()
        {

        }

        // member methods

        public string PiratesCome()
        {
            Console.WriteLine("While you are waiting for help, a pirate ship arrives and takes you prisoner. They take you to an island where they are searching for treasure. The island is populated by angry cannibals. You have a chance to escape when the pirates look away for a moment.");
            Console.WriteLine("Enter 1 to escape from the pirates by hiding on the island.");
            Console.WriteLine("Enter 2 to stay with the pirates.");
            string waitForHelpUserChoice = Console.ReadLine();
            return waitForHelpUserChoice;
        }



        public void StayWithPirates()
        {
            Console.WriteLine("You go back to the ship with the pirates and sail away. They make you walk the plank. You lose. Game over.");
        }



        public void SwimToIslandAndGetEaten()
        {
            Console.WriteLine("To avoid the sharks, you swim to the island of cannibals. When you reach the shore, the cannibals attack and eat you. You lose. Game over.");
        }



    }
}
