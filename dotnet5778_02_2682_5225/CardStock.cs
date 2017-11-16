using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    class CardStock :IEnumerable
    {
        private List<Card> Cards = new List<Card>();
        //constractor - initializes the deck with 26 cards
        public CardStock()
        {
            for (int i = 2; i < 15; i++)
            {
                Cards.Add(new Card(E_color.red, i));
                Cards.Add(new Card(E_color.black, i));
            }
        }

        //suffle the deck 
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

        //swap between to card
        private void swap(int first, int secend)
        {
            Card tmp = Cards[first];
            Cards[first] = Cards[secend];
            Cards[secend] = tmp;
        }

        //overloding to string return all card in the deck
        public override string ToString()
        {
            string temp1, temp2 = null;
            foreach (var item in Cards)
            {
                temp1 = item.ToString();
                temp2 += temp1 + '\n';
            }
            return temp2;
        }

        //distribute the deck between the player
        public void distribute(params Player[] players)
        {
            List<Card> temp;
            foreach (Player p in players)
            {
                temp = Cards.GetRange(0, (26 / players.Length));
                p.addCard(temp.ToArray());
                Cards.RemoveRange(0, 26 / (players.Length));
            }
        }

        //overloding indexer []
        public Card this[string name]
        {
            get
            {
                foreach (var item in Cards)
                {
                    if (item.CardName == name)
                        return item;
                }
                return null;
            }
        }

        //sort the deck
        public void sortStock()
        {
            Cards.Sort();
        }

        //add card 
        public void addCard(Card temp)
        {
            Cards.Add(temp);
        }

        //delete the first card
        public void removeCard()
        {
            Card temp = Cards[0];
            Cards.Remove(temp);
        }

        //overloding itrator for the foreach
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(Cards);
        }

        public class MyEnumerator : IEnumerator
        {
            private List<Card> _Cards;
            private int index=-1;
            public MyEnumerator(List<Card> temp) { _Cards = temp; }
            object IEnumerator.Current
            {
                get
                {
                    return _Cards[index];
                }
            }

            bool IEnumerator.MoveNext()
            {
                index++;
                if (index >= _Cards.Count)
                { index = -1; return false; }
                return true;
            }

            void IEnumerator.Reset()
            {
                index = -1;
            }
        }
    }
}

