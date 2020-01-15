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
        Player player1;
        Player player2;
        
        //Constructor

        //Member Methods (CAN DO)
        public void RunGame()
        {
            
            GameInstructions();
            SetGameMode();
        }

        public void GameInstructions()
        {
            Console.WriteLine("Welcome to this remake of the classic game of Battleship!\n" +
                "In this game there are two players, each player is given 5 ships of varying size\n" +
                "(Destroyer (space size: 2), Submarine (space size: 3), Battleship (space size: 4), and Aircraft Carrier (space size: 5)\n" +
                "and a blank board to choose where to set these ships in 'The Ocean'.\n" +
                "At the start of each turn, the list of the opponent's remaining ships is displayed.\n" +
                "Then each player during their turn takes a shot and trys to hit their opponent's ships.\n" +
                "If a shot hits a ship a 'X' is displayed on the board or if the shot misses a '0' is displayed on the board.\n" +
                "When a ship is sunk it is removed from the player's list of ships.\n" +
                "The players continue playing this way til the end of the game.\n" +
                "The goal of the game is to sink all of the opponent's ships in order to declare yourself a Battleship champion!\n" +
                "\nLet's get started! Hit any key to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public void SetGameMode()
        {
            string numplayers = ChooseNumPlayers();
            if (numplayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numplayers == "2")
            {
                string choice = HumanOrComp();
                
            }
               
        }

        public string ChooseNumPlayers()
        {
            Console.WriteLine("How many players? Please type a number: 1 or 2");
            string numplayers = Console.ReadLine();
            return numplayers;
        }

        public string HumanOrComp()
        {
            Console.WriteLine("Are the 2 players humans or computers?");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
