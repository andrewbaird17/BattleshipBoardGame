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
            // arrays read as [row,column]
            grid = new string[10,10];
        }
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
