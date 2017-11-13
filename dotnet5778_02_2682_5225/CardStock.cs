using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    class CardStock
    {
        private List<Card> Cards;
        //constractor
        public CardStock()
        {
            for (int i = 2; i < 15; i++)
            {
                Cards.Add(new Card(E_color.red, i));
                Cards.Add(new Card(E_color.black, i));
            }
        }

        public void shuffle()
        {
            Random r = new Random();
            int first, secend;
            for (int i = 1; i < 14; i++)
            {
                first = r.Next(1, 27);
                secend = r.Next(1, 27);
                if (first != secend) { swap(first, secend); }
            }
        }

        private void swap(int first, int secend)
        {
            Card tmp = Cards[first];
            Cards[first] = Cards[secend];
            Cards[secend] = tmp;
        }

//        public override string ToString()
//        {
//            string temp1,temp2=null;
//            foreach (var item in Cards)
//            {
//               temp1 = item.ToString();
//               temp2 += temp1 + '\n';
//            }
//            return temp2;
//        }

////        public void distribute(params Player[] players)
////        {
////            foreach (Player p in players)
//            {
//                for(int i=0;i<players.Length;i++)
//                   // p.addCard(Cards.to)
//            }

//        }

//    }
//}

