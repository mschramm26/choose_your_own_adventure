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
            Adventure adventure = new Adventure();
            adventure.adventure();

            Adventure exitGame = new Adventure();
            exitGame.ExitGame();

        }
    }
}
