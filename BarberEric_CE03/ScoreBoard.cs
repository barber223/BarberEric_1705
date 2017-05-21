using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberEric_CE03
{
    class ScoreBoard
    {
        private int xWins = 0;
        private int oWins = 0;

        public int OWins
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
        public int XWins
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
