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
        PlayerSetup setup;
        GameSetup gamesetup;
        //Constructor
        public Game()
        {
            setup = new PlayerSetup();
            gamesetup = new GameSetup();
        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            setup.GameStartUp();
            gamesetup.RunGameSetup();
        }

    }
}


