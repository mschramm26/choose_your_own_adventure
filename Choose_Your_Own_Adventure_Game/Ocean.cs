using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Ocean
    {
        // member variables
        string userInput;

        // constructor
        public Ocean()
        {

        }

        // member methods
        public string StormOnBoat()
        {
            Console.WriteLine("You are on your boat in the ocean. It begins to storm!");
            Console.WriteLine("Enter 1 to anchor the boat and wait out the storm.");
            Console.WriteLine("Enter 2 to keep going and look for a safer spot.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public string RunOutOfGas()
        {
            Console.WriteLine("The storm passes. You resume traveling, but you run out of gas.");
            Console.WriteLine("Enter 1 to radio for help and wait for help to arrive.");
            Console.WriteLine("Enter 2 to put on a life jacket and swim for shore.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public string BoatFloods()
        {
            Console.WriteLine("The boat begins to flood.");
            Console.WriteLine("Enter 1 to call the Coast Guard and wait for help.");
            Console.WriteLine("Enter 2 to try to save the boat by removing the water.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public string SeeSharks()
        {
            Console.WriteLine("While swimming, you see sharks blocking your path to the mainland.");
            Console.WriteLine("Enter 1 to swim toward the mainland anyway.");
            Console.WriteLine("Enter 2 to swim in the other direction to a nearby island where angry cannibals live.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");
            return userInput;
        }

        public void CoastGuardRescueAndCrash()
        {
            Console.WriteLine("The Coast Guard rescues you by helicopter. The helicopter collides with a drone and crashes, but you survive.");
            Console.WriteLine("You win! Game over.");
        }

        public void TryToSaveBoat()
        {
            Console.WriteLine("You slip and fall overboard while trying to bail water out. You drown.");
            Console.WriteLine("You lose. Game over.");
        }

        public void SharkAttack()
        {
            Console.WriteLine("While you are swimming toward the mainland, the sharks attack. You die.");
            Console.WriteLine("You lose. Game over.");
        }


    }
}
