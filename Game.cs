using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {   //member variables (HAS A)
        public Mountain mountain;
        public Player player;
        public Ocean ocean;
        public string adventureLocation;
        public int score;
   
        //constructor(SPAWNER)

        public Game()
        {
            mountain = new Mountain();
            player = new Player();
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

        
        public void PickAdventure(string adventure)
        { 
            switch (adventure)
            {
                case "mountain":
                    Console.WriteLine("Enjoy the mountain\n" );
                    mountain.RunMountain();
                    break;
                case "ocean":
                    Console.WriteLine("Enjoy the ocean\n");
                    ocean.RunOcean();
                    break;
                default:
                    Console.WriteLine("Not a valid adventure choice");
                    break;
            }

        }

        public void UserAdventureInput()
        {
            adventureLocation = GetStringInput("Time to choose your own adventure. Where to start? The mountain or the ocean?");
            while (adventureLocation =="mountain" || adventureLocation == "ocean")
            {
                PickAdventure(adventureLocation);
                adventureLocation = GetStringInput("Where to next? mountain or ocean? Or type end to end the adventure.");
            }
            
        }

        public void RunGame()
        {

            player.GetPlayerName();
            UserAdventureInput();
            score = mountain.mountainHappinessPoints + ocean.oceanHappinessPoints;
            Console.WriteLine("Congratulations adventurer. You scored " + score);
            //player.GetPlayerScore();
          
        }


    }
}

        


