using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure_Game
{
    class Adventure
    {

        // member variables


        // constructor
        public Adventure()
        {

        }

        // member methods

        public void adventure()
        {
            //Player playerLocation = new Player(playerCurrentLocation);
            //playerLocation.playerCurrentLocation();

            Ocean stormOnBoat = new Ocean();
            string beginningPoint = stormOnBoat.StormOnBoat();

            switch (beginningPoint)
            {
                case "1":
                    Ocean anchorBoat = new Ocean();
                    string runOutOfGas = anchorBoat.RunOutOfGas();
                    switch (runOutOfGas)
                    {
                        case "1":
                            Island piratesCome = new Island();
                            string goWithPiratesOrStayOnIsland = piratesCome.PiratesCome();

                            switch (goWithPiratesOrStayOnIsland)
                            {
                                case "1":
                                    Mainland makeFriendsWithCannibalsAndGoHome = new Mainland();
                                    string flyOrDrive = makeFriendsWithCannibalsAndGoHome.EscapeFromPirates();
                                    switch (flyOrDrive)
                                    {
                                        case "1":
                                            Mainland planeCrash = new Mainland();
                                            planeCrash.PlaneCrashes();
                                        break;
                                        case "2":
                                            Mainland driveHome = new Mainland();
                                            driveHome.DriveCar();
                                        break;
                                    }
                                    break;
                                case "2":
                                    Island walkPlank = new Island();
                                    walkPlank.StayWithPirates();
                                break;
                            }
                        break;
                        case "2":
                            Ocean seeSharks = new Ocean();
                            string decisionAfterSeeingSharks = seeSharks.SeeSharks();
                            switch (decisionAfterSeeingSharks)
                            {
                                case "1":
                                    Ocean killedBySharks = new Ocean();
                                    killedBySharks.SharkAttack();
                                break;
                                case "2":
                                    Island eatenByCannibals = new Island();
                                    eatenByCannibals.SwimToIslandAndGetEaten();
                                break;
                            }
                        break;
                    }
                    break;
                case "2":
                    Ocean keepGoing = new Ocean();
                    string callCoastGuardOrNot = keepGoing.BoatFloods();
                    switch (callCoastGuardOrNot)
                    {
                        case "1":
                            Ocean CoastGuardRescueAndCrash = new Ocean();
                            CoastGuardRescueAndCrash.CoastGuardRescueAndCrash();
                        break;

                        case "2":
                            Ocean TryToSaveBoat = new Ocean();
                            TryToSaveBoat.TryToSaveBoat();
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Please enter valid input.");
                    break;
            }


        }

        public void ExitGame()
        {
            Console.WriteLine("Enter E to exit the game.");
            string exitGame = Console.ReadLine();
            if (exitGame == "E")
            {
                Environment.Exit(0);
            }

        }

    }
}
