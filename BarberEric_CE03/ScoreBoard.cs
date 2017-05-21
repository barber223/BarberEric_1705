using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberEric_CE03
{
    class ScoreBoard
    {
        private decimal xWins = 0m;
        private decimal oWins = 0m;

        public decimal OWins
        {
            get
            {
                return oWins;
            }
            set
            {
                oWins = value;
            }
        }
        public decimal XWins
        {
            get
            {
                return xWins;
            }
            set
            {
                xWins = value;
            }
        }

    }
}
