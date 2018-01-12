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


        // constructor
        public Mainland()
        {

        }

        // member methods
        public string EscapeFromPirates()
        {
            Console.WriteLine("You hide on the island. The pirates cannot find you and they sail away. The cannibals try to eat you, but you are able to talk them out of it. They let you build a boat, and you sail back to the mainland. When you get back to the mainland, do you get on a plane to fly back home or do you rent a car to drive home?");
            Console.WriteLine("Enter 1 to get on the plane.");
            Console.WriteLine("Enter 2 to rent a car.");
            string planeOrCarDecision = Console.ReadLine();
            return planeOrCarDecision;

        }


        public void PlaneCrashes()
        {
            Console.WriteLine("The plane crashes and everyone dies. You lose. Game over.");
        }



        public void DriveCar()
        {
            Console.WriteLine("You drive back home and live happily ever after. You win. Game over.");
        }


    }
}
