using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player welcome = new Player();
            string welcomeInput = welcome.Welcome();

            while (welcomeInput != "B")
            {
                Console.WriteLine("Please enter valid input.");
                welcomeInput = Console.ReadLine();
            }

            while (welcomeInput == "B")
            {
                Adventure adventure = new Adventure();
                adventure.adventure();
                Player exitGameOrRestart = new Player();
                exitGameOrRestart.ExitOrRestartGame();
            }


        }
    }
}
