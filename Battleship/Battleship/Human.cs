using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Human : Player
    {
        //Member Variables (HAS A)

        //Constructor
        public Human()
        {

        }
        //Member Methods (CAN DO)
        public override void SetName()
        {
            Console.WriteLine("Please enter your player name");
            userName = Console.ReadLine();
        }
    }
}
