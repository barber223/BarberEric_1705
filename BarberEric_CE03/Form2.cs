using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberEric_CE03
{
    public partial class Form2 : Form
    {
        public event EventHandler<SelectType> selection;

        public class SelectType: EventArgs
        {
            public string type;

            public SelectType(string ty )
            {
                this.type = ty;
            }
        }
        

        public Form2 ( )
        {
            InitializeComponent ( );
        }

        private void btnOk_Click ( object sender,EventArgs e )
        {
            string type;
            if (PlayerSelction.Text != null)
            {
                type = PlayerSelction.Text;
                if (selection != null)
                {
                    selection ( this,new SelectType(type) );
                }

                this.Close ( );
            }

            
        }
    }
}
