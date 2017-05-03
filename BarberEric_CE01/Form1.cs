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
            

            ListViewItem/*.ListViewSubItem*/ it = new ListViewItem ( );//.ListViewSubItem ( );

            it.Text = txtItem.Text;

            listView1.Items.Add (  it);//.SubItems.Add ( item );

            //listView1.Items[0].SubItems.Add (  "please" );


            //MessageBox.Show ( listView1.Items[0].ToString ( ) );


        }

        private void btnMove_Click ( object sender,EventArgs e )
        {
            if (index != -1)
            {
                /*
                if (listView1.Items[0].SubItems.Contains ( listView1.Items[0].SubItems[index] ))
                {

                    for (int i = 0; i < listView1.Items[0].SubItems.Count; i++)
                    {
                        if (listView1.Items[0].SubItems[index] == listView1.Items[0].SubItems[i])
                        {

                            MessageBox.Show ( listView1.Items[0].SubItems[index].Text );

                            listView1.Items[1].SubItems.Add ( listView1.Items[0].SubItems[index] );
                            listView1.Items[0].SubItems.Remove ( listView1.Items[0].SubItems[index] );


                            //MessageBox.Show ( "did it recognize" );
                        }

                    }
                    */


                }

                else if (listView1.Items[1].SubItems.Contains ( listView1.Items[1].SubItems[index] ))
                {

                }



                //MessageBox.Show ( "working" );
                index = -1;
            }
        

        private void listView1_MouseDoubleClick ( object sender,MouseEventArgs e )
        {
            index = listView1.Items.IndexOf ( listView1.SelectedItems[0]);
            
        }

        private void listView1_MouseClick ( object sender,MouseEventArgs e )
        {
            index = listView1.Items.IndexOf ( listView1.SelectedItems[0] );
        }
    }
}
