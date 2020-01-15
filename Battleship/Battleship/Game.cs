using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        //Member Variables (HAS A)
        //Player player1;
        //Player player2;

        //Constructor

        //Member Methods (CAN DO)
        public void RunGame()
        {

            GameInstructions();
            SetGameMode();
        }

        private void GameInstructions()
        {
            Console.WriteLine("Welcome to this remake of the classic game of Battleship!\n" +
                "In this game there are two players, each player is given 5 ships of varying size\n" +
                "(Destroyer (space size: 2), Submarine (space size: 3), Battleship (space size: 4), and Aircraft Carrier (space size: 5)\n" +
                "and a blank board to choose where to set these ships in 'The Ocean'.\n" +
                "Ships can only be placed vertically and horizontally. Overlapping ships and diagonal placement WILL NOT BE TOLERATED!\n" +
                "The goal of the game is to sink all of the opponent's ships in order to declare yourself a Battleship champion!\n" +
                "\nHit any key to continue to game play basics.");
            Console.ReadLine();
            Console.WriteLine("At the start of each turn, the list of the opponent's remaining ships is displayed.\n" +
                "Then each player during their turn takes a shot and trys to hit their opponent's ships.\n" +
                "If a shot hits a ship a X is displayed on the board or if the shot misses a 0 is displayed on the board.\n" +
                "HIT or MISS will be displayed on screen along with the corresponding spot chosen on the board.\n" +
                "When a ship is sunk it is removed from the player's list of ships.\n" +
                "The players continue playing this way til the end of the game.\n" +
                "If you successfully eliminate all of your opponent's ships, remeber you will be declared the Battleship champion!\n" +
                "\nLet's get started! Hit any key to continue");
            Console.ReadLine();
        }

        public void SetGameMode()
        {
            SetNumPlayers();
        }

        public void SetNumPlayers()
        {
            int setNumberOfPlayers = 0;
            bool success = false;

            // validate numofPlayers to a valid #player
            do
            {
                Console.Clear();
                Console.WriteLine("Choose number of players! Must be a number");
                string numOfPlayers = Console.ReadLine();
                if (numOfPlayers == "1")
                {
                    Console.WriteLine("Please try again. 1 player is not a valid option.");
                }
                else
                {
                    success = Int32.TryParse(numOfPlayers, out setNumberOfPlayers);
                }

            } while (success == false);
            Console.Clear();
            TypesofPlayers(setNumberOfPlayers);
        }
        public void TypesofPlayers(int setNumberofPlayers)
        {
            Console.WriteLine(setNumberofPlayers);
            Console.ReadLine();
        }
    }
}
