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
                "Then each player takes turns taking a shot and trying to hit their opponent ships.\n" +
                "The goal of the game is to sink all of the opponent's ships in order to declare yourself a Battleship champion!\n" +
                "\nLet's get started! Hit any key to continue");
            Console.ReadLine();
            SetGameMode();
        }

        public void SetGameMode()
        {

        }
    }
}
