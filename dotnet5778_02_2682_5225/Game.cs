using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    public partial class Game
    {
       private CardStock kupa = new CardStock();
       private Player ido, yohanan;
        #region property
        internal CardStock Kupa
        {
            get
            {
                return kupa;
            }

            set
            {
                kupa = value;
            }
        }

        internal Player Ido
        {
            get
            {
                return ido;
            }

            set
            {
                ido = value;
            }
        }

        internal Player Yohanan
        {
            get
            {
                return yohanan;
            }

            set
            {
                yohanan = value;
            }
        }
        #endregion

        public Game()
        {
            ido = new Player("ido");
            yohanan = new Player("yohanan");
        }

        


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
        public void step()//pops 2 cards, one from each player, and compare between them
        {
            Card[] war = new Card[2];
            war[0] = ido.pop();
            war[1] = yohanan.pop();
            if (war[0].Number > war[1].Number)
            {
                ido.addCard(war);
                Console.WriteLine(ido);
                Console.WriteLine(yohanan);
            }
            else if (war[1].Number > war[0].Number)
            {
                yohanan.addCard(war);
                Console.WriteLine(ido);
                Console.WriteLine(yohanan);
            }
            else
            {
                evenCards(war);//function that check the next pair of cards in a reccursive way until someone is winning

            }
        }

        private void evenCards(Card[] war)
        {
            Card[] bigWar = new Card[war.Count() + 4];//define array that bigger then the last one, for insert all the cards
            int index = war.Count();
            for (int i = 0; i < index; i++)
                bigWar[i] = war[i];
            bigWar[index] = ido.pop();
            bigWar[index + 1] = ido.pop();
            bigWar[index+2] = yohanan.pop();
            bigWar[index + 3] = yohanan.pop();
            if (!ido.lose())
            {
                foreach (var item in bigWar)
                {
                    if (item != null)
                        yohanan.addCard(item);
                }
                return;
            }
            if (!yohanan.lose())
            {
                foreach (var item in bigWar)
                {
                    if (item != null)
                        ido.addCard(item);
                }
                return;
            }
            if (bigWar[index+1].Number > bigWar[index + 3].Number)
            {
                ido.addCard(bigWar);
                Console.WriteLine(ido);
                Console.WriteLine(yohanan);
            }
            else if (bigWar[index + 3].Number > bigWar[index+1].Number)
            {
                yohanan.addCard(bigWar);
                Console.WriteLine(ido);
                Console.WriteLine(yohanan);
            }
            else evenCards(bigWar);//if the second couple of cards is still evevn, we get into reccursive method that stops when someone win
        }
    }
}

