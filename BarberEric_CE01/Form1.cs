using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberEric_CE01
{
    public partial class GroceryList : Form
    {
        int index = -1;
     


        public GroceryList ( )
        {
            InitializeComponent ( );
        }

        private void btnAdd_Click ( object sender,EventArgs e )
        {
          listNeed.Items.Add ( txtItem.Text);
        }

        private void btnMove_Click ( object sender,EventArgs e )
        {
          
         if (listHave.SelectedItems != null)
            {
                for (int i = 0; i < listHave.Items.Count; i++)
                {
                    if (listHave.SelectedItem == listHave.Items[i])
                    { 
                        listNeed.Items.Add (listHave.Items[i] );
                        listHave.Items.Remove ( listHave.Items[i] );
                    }
                }
            }
           if (listNeed.SelectedItems != null)
            {
                for (int i = 0; i < listNeed.Items.Count; i++)
                {
                    if (listNeed.Items[i] == listNeed.SelectedItem)
                    {

                        listHave.Items.Add ( listNeed.Items[i] );
                        listNeed.Items.Remove ( listNeed.SelectedItem );
                    }
                } 
            }
        }
        

       
        private void listView1_MouseClick ( object sender,MouseEventArgs e )
        {
            
        }

        private void btnRemove_Click ( object sender,EventArgs e )
        {
            if (listNeed.SelectedItem != null)
            {
              for (int i = 0; i < listNeed.Items.Count; i++)
                {
                    if (listNeed.Items[i] == listNeed.SelectedItem)
                    {
                        listNeed.Items.Remove ( listNeed.SelectedItem );
                    }
                }
            }
            else if (listHave.SelectedItem != null) 
            {
                for (int i = 0; i < listNeed.Items.Count; i++)
                {
                    if (listHave.Items[i] == listHave.SelectedItem)
                    {
                        listHave.Items.Remove ( listHave.Items[i] );
                    }
                }
            }
        }
    }
}
