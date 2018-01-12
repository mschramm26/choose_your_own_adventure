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


        // constructor
        public Ocean()
        {

        }

        // member methods
        public string StormOnBoat()
        {
            Console.WriteLine("You are on your boat in the ocean. There is a storm.");
            Console.WriteLine("Enter 1 to anchor the boat and wait out the storm.");
            Console.WriteLine("Enter 2 to keep going and look for a safer spot.");
            string stormOnBoatUserChoice = Console.ReadLine();
            return stormOnBoatUserChoice;
        }

        public string RunOutOfGas()
        {
            Console.WriteLine("The storm passes. You unanchor and keep traveling, but you run out of gas after a while.");
            Console.WriteLine("Enter 1 to radio for help and wait for help to arrive.");
            Console.WriteLine("Enter 2 to put on a life jacket and swim for shore.");
            string runOutOfGasUserChoice = Console.ReadLine();
            return runOutOfGasUserChoice;
        }

        public string BoatFloods()
        {
            Console.WriteLine("The boat begins to flood.");
            Console.WriteLine("Enter 1 to call the Coast Guard and wait for help.");
            Console.WriteLine("Enter 2 to try to save the boat by removing the water.");
            string runOutOfGasUserChoice = Console.ReadLine();
            return runOutOfGasUserChoice;
        }

        public string SeeSharks()
        {
            Console.WriteLine("While swimming, you see sharks blocking your path to the mainland.");
            Console.WriteLine("Enter 1 to swim toward the mainland anyway.");
            Console.WriteLine("Enter 2 to swim the other way to a nearby island where angry cannibals live.");
            string seeSharksUserChoice = Console.ReadLine();
            return seeSharksUserChoice;
        }

        public void CoastGuardRescueAndCrash()
        {
            Console.WriteLine("The Coast Guard rescues you by helicopter. The helicopter collides with a drone and crashes on a nearby island. You survive. You win. Game over.");
        }

        public void TryToSaveBoat()
        {
            Console.WriteLine("You slip and fall overboard while trying to bail water out. You drown. You lose. Game over.");
        }

        public void SharkAttack()
        {
            Console.WriteLine("While you are swimming toward the mainland, the sharks attack. You die. You lose. Game over.");
        }


    }
}
