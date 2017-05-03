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
        string item;

        public GroceryList ( )
        {
            InitializeComponent ( );
        }

        private void btnAdd_Click ( object sender,EventArgs e )
        {
            item = txtItem.Text;

            ListViewItem/*.ListViewSubItem*/ it = new ListViewItem ( );//.ListViewSubItem ( );

            it.Text = item;

            listView1.Items.Add (  it);//.SubItems.Add ( item );

            //listView1.Items[0].SubItems.Add (  "please" );


            //MessageBox.Show ( listView1.Items[0].ToString ( ) );


        }

        private void btnMove_Click ( object sender,EventArgs e )
        {

        }

        private void listView1_MouseDoubleClick ( object sender,MouseEventArgs e )
        {
            
        }
    }
}
