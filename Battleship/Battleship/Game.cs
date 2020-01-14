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
            GameGrid grid = new GameGrid();
            Console.WriteLine(grid);
            Console.ReadLine();
        }
    }
}
