using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Player
    {

        // member variables
        public double healthInitial;
        public double healthPercentageCurrent;
        public string userInput;

        // constructor
        public Player()
        {

        }

        //member methods
        public string Welcome()
        {
            Console.WriteLine("CHOOSE YOUR OWN ADVENTURE\n");
            Console.WriteLine("Enter B to begin the game.");
            userInput = Console.ReadLine();
            return userInput;
        }

        public double HealthInitialDisplay()
        {
            healthInitial = 100;
            Console.WriteLine("Health level: " + healthInitial + "%");
            return healthInitial;
        }
        
        public double healthPercentageDeduction(double currentHealth)
        {
            healthPercentageCurrent = currentHealth - 25;
            return healthPercentageCurrent;
        }

        public void healthPercentageDisplay(double healthPercentageCurrent)
        {
            Console.WriteLine("Health level: " + healthPercentageCurrent + "%");
        }

        public void ExitOrRestartGame()
        {
            Console.WriteLine("Enter E to exit the game.");
            Console.WriteLine("Enter R to play again.");
            string exitGameOrRestart = Console.ReadLine();
            if (exitGameOrRestart == "E")
            {
                Environment.Exit(0);
            }
            while (exitGameOrRestart == "R")
            {
                Adventure adventure = new Adventure();
                adventure.adventure();
                Player exitOrRestart = new Player();
                exitOrRestart.ExitOrRestartGame();

            }
        }


    }
}
