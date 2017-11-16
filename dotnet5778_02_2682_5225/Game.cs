using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    public partial class Game
    {
        CardStock kupa;
        Player ido, yohanan;
        public void startGame()
        {
            kupa.shuffle();
            kupa.distribute(ido, yohanan);
        }
       public bool endGame()
        {
            if (!(ido.lose()) ||!( yohanan.lose()))
                return true;
            else return false;
        }
    }
}
