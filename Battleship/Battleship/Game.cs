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
        public PlayerSetup setup;
        //Constructor
        public Game()
        {
            setup = new PlayerSetup();
        }
        //Member Methods (CAN DO)
        public void RunGame()
        {
            setup.GameStartUp();
        }

    }
}


