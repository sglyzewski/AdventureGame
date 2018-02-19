using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        //member variables (HAS A)
        public string playerName;
        public int playerScore;
        public Mountain mountain;
        public Ocean ocean;
       
        //constructor(SPAWNER)
        public Player()
        {
            playerName = "";


            mountain = new Mountain();
            ocean = new Ocean();
        }

        //member methods (CAN DO)
        public string GetStringInput(string message)
        {
            string input;
            Console.WriteLine(message);
            input = Console.ReadLine();
            return input;
        }

        public string GetPlayerName()
        {
            playerName = GetStringInput("What is your name?");
            return playerName;
        }

        public void GetPlayerScore()
        {
            playerScore = mountain.mountainHappinessPoints + ocean.oceanHappinessPoints;
            Console.WriteLine(playerName + ", your total adventure score is: " + playerScore + " points");
            

        }
    }
}
