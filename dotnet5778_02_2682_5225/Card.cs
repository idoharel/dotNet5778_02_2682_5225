using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{

    enum E_color { red, black }
    //class define card in stack
    class Card : IComparable
    {
        private int number;
        private E_color color;
        

        #region property
        public int Number
        {
            get { return number; }

            set
            {
                if (number > 1 && number < 15)
                    number = value;
            }
        }

        internal E_color Color { get; set; }

        public string CardName
        {
            get
            {
                if (number == 11) { return "Jack"; }
                else if (number == 12) { return "Queen"; }
                else if (number == 13) { return "King"; }
                else if (number == 14) { return "Ace"; }
                else { return number.ToString(); }
            }
        }
        #endregion

        //CTOR
        public Card(E_color col, int num)
        {
            color = col;
            number = num;
        }

        //override toString to return name and color card
        public override string ToString()
        {
            return CardName + " "+color.ToString();
        }

        //comper between cards
        public int CompareTo(object obj)
        {
            return number.CompareTo(((Card)obj).number);
        }
    }
}
//


