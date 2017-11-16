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
            Console.WriteLine("Hello, welcome to the game,\n the player:");
            theGame.Yohanan.ToString();
            theGame.Ido.ToString();
            Console.WriteLine("to run all game press-0 \nto see the next steps press-1");
            do
            {
                if (theGame.endGame()) { break; }
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        {
                            while(true)
                            {
                                theGame.step();
                                if (theGame.endGame()) { Console.WriteLine(theGame.checkVictory()); break; }
                            }
                            break;
                        }
                    case 1:
                        {
                            theGame.step();
                            if (theGame.endGame()) { Console.WriteLine(theGame.checkVictory()); }
                                break;
                        }
                    default:
                        Console.WriteLine("wrong choice, choice again");
                        break;
                }
            }
            while (true);
        }
    }
}
