using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        //Member Variables (HAS A)
        public GameGrid grid;
        //Constructor

        //Member Methods (CAN DO)

        public void DisplayGrid()
        {
            GameGrid grid = new GameGrid();
            for (int i = 0; i < grid.grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.grid.GetLength(1); j++)
                {
                    Console.Write("[ " + grid.grid[i, j] + "] ");
                }
                Console.WriteLine(" \n");
            }
            Console.ReadLine();
        }
    }
}
