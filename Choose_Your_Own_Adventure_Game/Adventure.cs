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
            Console.WriteLine("\n");
            Player score = new Player();
            double startHealth = score.HealthInitialDisplay();
            Ocean stormOnBoat = new Ocean();
            string startPoint = stormOnBoat.StormOnBoat();
            switch (startPoint)
            {
                case "1":
                    Ocean anchorBoat = new Ocean();
                    double healthAnchorBoat = score.healthPercentageDeduction(startHealth);
                    score.healthPercentageDisplay(healthAnchorBoat);
                    string runOutOfGas = anchorBoat.RunOutOfGas();
                    switch (runOutOfGas)
                    {
                        case "1":
                            Island piratesCome = new Island();
                            double healthPiratesCome = score.healthPercentageDeduction(healthAnchorBoat);
                            score.healthPercentageDisplay(healthPiratesCome);
                            string goWithPiratesOrStayOnIsland = piratesCome.PiratesCome();
                            switch (goWithPiratesOrStayOnIsland)
                            {
                                case "1":
                                    Mainland makeFriendsWithCannibalsAndGoHome = new Mainland();
                                    double healthMakeFriendsWithCannibalsAndGoHome = score.healthPercentageDeduction(healthPiratesCome);
                                    score.healthPercentageDisplay(healthMakeFriendsWithCannibalsAndGoHome);
                                    string flyOrDrive = makeFriendsWithCannibalsAndGoHome.EscapeFromPirates();
                                    switch (flyOrDrive)
                                    {
                                        case "1":
                                            Mainland planeCrash = new Mainland();
                                            double healthPlaneCrash = score.healthPercentageDeduction(healthMakeFriendsWithCannibalsAndGoHome);
                                            score.healthPercentageDisplay(healthPlaneCrash);
                                            planeCrash.PlaneCrashes();
                                            break;
                                        case "2":
                                            Mainland driveHome = new Mainland();
                                            double healthDriveHome = score.healthPercentageDeduction(healthMakeFriendsWithCannibalsAndGoHome);
                                            score.healthPercentageDisplay(healthDriveHome);
                                            driveHome.DriveCar();
                                        break;
                                    }
                                    break;
                                case "2":
                                    Island walkPlank = new Island();
                                    double healthWalkPlank = score.healthPercentageDeduction(healthPiratesCome);
                                    score.healthPercentageDisplay(healthWalkPlank);
                                    walkPlank.StayWithPirates();
                                break;
                                default:
                                    Console.WriteLine("You have entered invalid input.");
                                    break;
                            }
                            break;
                        case "2":
                            Ocean seeSharks = new Ocean();
                            double healthSeeSharks = score.healthPercentageDeduction(healthAnchorBoat);
                            score.healthPercentageDisplay(healthSeeSharks);
                            string decisionAfterSeeingSharks = seeSharks.SeeSharks();
                            switch (decisionAfterSeeingSharks)
                            {
                                case "1":
                                    Ocean killedBySharks = new Ocean();
                                    double healthKilledBySharks = score.healthPercentageDeduction(healthSeeSharks);
                                    score.healthPercentageDisplay(healthKilledBySharks);
                                    killedBySharks.SharkAttack();
                                break;
                                case "2":
                                    Island eatenByCannibals = new Island();
                                    double healthEatenByCannibals = score.healthPercentageDeduction(healthSeeSharks);
                                    score.healthPercentageDisplay(healthEatenByCannibals);
                                    eatenByCannibals.SwimToIslandAndGetEaten();
                                break;
                                default:
                                    Console.WriteLine("You have entered invalid input.");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("You have entered invalid input.");
                            break;
                    }
                    break;
                case "2":
                    Ocean keepGoing = new Ocean();
                    double healthKeepGoing = score.healthPercentageDeduction(startHealth);
                    score.healthPercentageDisplay(healthKeepGoing);
                    string callCoastGuardOrNot = keepGoing.BoatFloods();
                    switch (callCoastGuardOrNot)
                    {
                        case "1":
                            Ocean CoastGuardRescueAndCrash = new Ocean();
                            double healthCoastGuardRescueAndCrash = score.healthPercentageDeduction(healthKeepGoing);
                            score.healthPercentageDisplay(healthCoastGuardRescueAndCrash);
                            CoastGuardRescueAndCrash.CoastGuardRescueAndCrash();
                        break;
                        case "2":
                            Ocean TryToSaveBoat = new Ocean();
                            double healthTryToSaveBoat = score.healthPercentageDeduction(healthKeepGoing);
                            score.healthPercentageDisplay(healthTryToSaveBoat);
                            TryToSaveBoat.TryToSaveBoat();
                        break;
                        default:
                            Console.WriteLine("You have entered invalid input.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("You have entered invalid input.");
                    break;
            }


        }


    }
}
