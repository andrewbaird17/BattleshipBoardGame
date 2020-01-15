using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class GameGrid
    {
        //Member Variables (HAS A)

        public string[,] grid;
        //Constructor
        public GameGrid()
        {
            // Mike said doing a 10 x 10 game board would be okay
            grid = new string[10,10];
        }
        //Member Methods (CAN DO)

    }
}
