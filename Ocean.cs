using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Ocean
    {//member variables (HAS A)
        public int oceanHappinessPoints;
        public string getScubaCertified;
        public string learnToSurf;
        public string sharkAttack;
        public string haveASmoothie;
        //constructor(SPAWNER)
        public Ocean()
        {
     
            getScubaCertified = "You have your PADI certification. Explore the deep blue!";
            learnToSurf = "Gnarly waves man. You learned how to surf";
            sharkAttack = "You lost your arm to a great white. hello hospital.";
            haveASmoothie = "HAve a healthey and delicious beverage in the salty air.";
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


        public void GiveMessage(string message)
        {
            Console.WriteLine(message);
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
                    GiveMessage(getScubaCertified);
                    oceanHappinessPoints += 12;
                    break;
                case 2:
                    GiveMessage(learnToSurf);
                    oceanHappinessPoints += 10;

                    break;
                case 3:
                    GiveMessage(sharkAttack);
                    oceanHappinessPoints += 1;
                    break;
                case 4:
                    GiveMessage(haveASmoothie);
                    oceanHappinessPoints += 5;
                    break;

                default:
                    Console.WriteLine("You just sat around what the heck");
                    oceanHappinessPoints += 0;
                    break;
            }
        }

        public int RunOcean()
        {

            string userDecision = GetStringInput("Welcome to the ocean! Would you like to roll for your next adventure? Type yes to do so");
            while (userDecision == "yes")
            {
                GetAdventure();
                GiveMessage("You've earned " + oceanHappinessPoints + " total happiness points on the ocean!\n");
                userDecision = GetStringInput("Would you like to stay and get more adventures here? \n");
                if (userDecision != "yes")
                {
                    break;
                }
            }

            GiveMessage("Total points scored on ocean: " + oceanHappinessPoints);
            return oceanHappinessPoints;
            

        }

     
    }
     

       
    }


