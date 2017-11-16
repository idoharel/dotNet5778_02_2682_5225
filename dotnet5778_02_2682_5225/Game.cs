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
            if (!(ido.lose()) || !(yohanan.lose()))
                return true;
            else return false;
        }
        public void step()
        {
            Card[] war = new Card[2];
            war[0] = ido.pop();
            war[1] = yohanan.pop();
            if (war[0].Number > war[1].Number)
                ido.addCard(war);
            else if (war[1].Number > war[0].Number)
                yohanan.addCard(war);
            else
            {
                Card[] bigWar = new Card[4];
                bigWar = war;
                bigWar[2] = ido.pop();
                bigWar[3] = yohanan.pop();
            }
        }
    }
}

