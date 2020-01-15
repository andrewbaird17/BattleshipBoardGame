using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Game
    {
        //Member Variables (HAS A)
        public PlayerSetup playersetup = new PlayerSetup();
        public GameSetup gamesetup = new GameSetup();
        //Constructor
        public Game()
        {
          
        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            playersetup.PlayerStartUp();
            gamesetup.RunGameSetup();
        }

    }
}


