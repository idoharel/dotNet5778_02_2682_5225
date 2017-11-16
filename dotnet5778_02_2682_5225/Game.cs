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

        public Game()
        {
            ido = new Player("ido");
            yohanan = new Player("yohanan");
        }

        internal Player Ido { get; }
        internal Player Yohanan { get; }


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
                evenCards(war);//function that check the next pair of cards in a reccursive way until someone is winning

            }
        }

        private void evenCards(Card[] war)
        {
            Card[] bigWar = new Card[war.Count()+2];
            bigWar = war;
            bigWar[war.Count()] = ido.pop();
            bigWar[war.Count() + 1] = yohanan.pop();
            if (bigWar[war.Count()].Number > bigWar[war.Count() +1 ].Number)
                ido.addCard(bigWar);
            else if (bigWar[war.Count()].Number > bigWar[war.Count() + 1].Number)
                yohanan.addCard(bigWar);
            else evenCards(bigWar);
        }
    }
}

