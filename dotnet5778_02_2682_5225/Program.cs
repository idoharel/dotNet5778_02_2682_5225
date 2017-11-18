using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Game theGame = new Game();
            theGame.startGame();
            Console.WriteLine("Hello, welcome to the game,\nthe player:");
            Console.WriteLine(theGame.Yohanan);
            Console.WriteLine(theGame.Ido);
            do
            {
                if (theGame.endGame()) { break; }
                Console.WriteLine("To run the entire game press-0 \nTo see the next steps press-1");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0://run until one of the players wins
                        while (theGame.endGame() != true)
                            theGame.step();
                        break;
                    case 1://run one battle at a tןme
                            theGame.step();
                                break;
                    default:
                        Console.WriteLine("Wrong choice, try again");
                        break;
                }
            }
            while (true);
            theGame.checkVictory();
        }
    }
}
