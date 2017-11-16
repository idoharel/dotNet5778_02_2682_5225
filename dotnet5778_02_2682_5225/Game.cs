using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    public partial class Game
    {
       private CardStock kupa;
       private Player ido, yohanan;

        internal Player Ido { get; }
        internal Player Yohanan { get; }


        public void startGame()
        {
            kupa.shuffle();
            kupa.distribute(ido, yohanan);
        }
    }
}
