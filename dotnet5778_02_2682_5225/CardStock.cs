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
       
        private CardStock()
        {
            for (int i = 2; i < 15; i++)
                i = i + 3;
        }
    }

}
//שינוי
