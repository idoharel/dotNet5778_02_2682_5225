using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    public partial class Game
    {
        public void checkVictory()
        {
            if (!ido.lose()) Console.WriteLine("\nThe winner is " + yohanan.Name + "\n");
            else Console.WriteLine("\nThe winner is " + ido.Name + "\n");
        }
               
        public override string ToString()
        {
            return yohanan.Name + ' ' + yohanan.PlayerCards.Count() + '\n' + ido.Name + ' ' + ido.PlayerCards.Count();
        }
    }
}
