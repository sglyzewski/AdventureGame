using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Mountain
    {   //member variables (HAS A)
        public int mountainHappinessPoints;
        public string topRopeMultiPitch;
        public string summit;
        public string horsebackRideHero;
        public string leadTenPitch;
        //constructor(SPAWNER)
        public Mountain()
        {

            topRopeMultiPitch = "You found some friends to help you top rope your first mutlipitch route. You're a mountain climber!";
            summit = "You summited a mountain";
            horsebackRideHero = "Your new friend fell off the cliff and you raced down the mountain by horseback to save him just before he died.";
            leadTenPitch = "You and all your trad gear lead a ten pitch route in the gorgeous wind river range. Badass!";

        }

        //member methods (CAN DO)
        public static readonly Random getRandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getRandom) // synchronize
            {
                return getRandom.Next(min, max);
            }
        }

        public int GetAdventureRoll()
        {
            int roll;
            roll = GetRandomNumber(1, 5);
            return roll;
        }

        public string GetStringInput(string message)
        {
            string input;
            Console.WriteLine(message);
            input = Console.ReadLine();
            return input;
        }

        public void GetAdventure()
        {
            int roll;
            roll = GetAdventureRoll();
            switch (roll)
            {
                case 1:
                    GiveMessage(topRopeMultiPitch);
                    mountainHappinessPoints += 12;
                    break;
                case 2:
                    GiveMessage(summit);
                    mountainHappinessPoints += 10;

                    break;
                case 3:
                    GiveMessage(horsebackRideHero);
                    mountainHappinessPoints += 1;
                    break;
                case 4:
                    GiveMessage(leadTenPitch);
                    mountainHappinessPoints += 5;
                    break;

                default:
                    Console.WriteLine("You just sat around what the heck");
                    mountainHappinessPoints += 0;
                    break;
            }
        }

            public void GiveMessage(string message)
            {
                Console.WriteLine(message);

            }

       public int RunMountain()
        {
            string userDecision = GetStringInput("Welcome to the mountain! Would you like to roll for your next adventure? Type yes to do so");

            while (userDecision == "yes")
            {
                GetAdventure();
                GiveMessage("You've earned " + mountainHappinessPoints + " total happiness points on the mountain!\n");
                userDecision = GetStringInput("Would you like to stay and get more adventures here? \n");
                if (userDecision != "yes")
                {
                    break;
                }

            }

            GiveMessage("Total points scored on mountain: " + mountainHappinessPoints);
            return mountainHappinessPoints;

        }
        
    }
}
