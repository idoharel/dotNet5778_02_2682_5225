using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5778_02_2682_5225
{
    public partial class Game
    {
        public string checkVictory()
        {
            if (!ido.lose()) { return yohanan.Name; }
            return ido.Name;
        }
    }
}
