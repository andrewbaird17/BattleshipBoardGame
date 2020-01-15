using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class GameSetup
    {
        //Member Variables (HAS A)

        //Constructor
        public GameSetup()
        {

        }

        //Member Methods (CAN DO)

        public void RunGameSetup()
        {
            GameMode();
        }
        public void GameMode()
        {
            Console.WriteLine("Let's start by choosing a game mode!\n" +
                "1) Basic [Players Take Turns attacking one another]\n" +
                "2) Salvo [Players Start with 5 Shots per turn and lose a shot for every ship that is sunk]\n" +
                "3) Speed [Players get to go again if their shot is a HIT, otherwise play advances to next player]");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }
    }
}
