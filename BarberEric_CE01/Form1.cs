using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            txtItem.Clear ( );
        }

        private void btnMove_Click ( object sender,EventArgs e )
        {
          
         if (listHave.SelectedIndex != -1)
            {
                for (int i = 0; i < listHave.Items.Count; i++)
                {
                    if (listHave.SelectedItem == listHave.Items[i])
                    { 
                        listNeed.Items.Add (listHave.Items[i] );
                        listHave.Items.Remove ( listHave.Items[i] );
                    }
                }
                listHave.ClearSelected ( );
            }
           if (listNeed.SelectedIndex != -1)
            {
                for (int i = 0; i < listNeed.Items.Count; i++)
                {
                    if (listNeed.Items[i] == listNeed.SelectedItem)
                    {

                        listHave.Items.Add ( listNeed.Items[i] );
                        listNeed.Items.Remove ( listNeed.SelectedItem );
                    }
                }
                listNeed.ClearSelected ( );
            }
        }
        

       
       

        private void btnRemove_Click ( object sender,EventArgs e )
        {
            if (listNeed.SelectedIndex != -1)
            {
                listNeed.Items.Remove ( listNeed.SelectedItem );
                listNeed.ClearSelected ( );

            }
            else if (listHave.SelectedIndex != -1) 
            {
                listHave.Items.Remove(listHave.SelectedItem);
                listHave.ClearSelected ( );
            }
        }

        private void listNeed_SelectedIndexChanged ( object sender,EventArgs e )
        {
            txtItem.Text = listNeed.Text;
        }

        private void listHave_SelectedIndexChanged ( object sender,EventArgs e )
        {
            txtItem.Text = listNeed.Text;
        }

        private void exitToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            Application.Exit ( );
        }

        private void saveToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            Stream myStream;   // set the stream
            SaveFileDialog saveFile = new SaveFileDialog ( );  //
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog ( ) == DialogResult.OK)
            {
                if ((myStream = saveFile.OpenFile ( )) != null)
                {
                    using (TextWriter files = new StreamWriter ( myStream ))
                    {
                        //TextWriter files;
                        string needBox= "";
                        string HaveBox = "";
                        string saveString = "";

                        for (int i = 0; i < listNeed.Items.Count; i++)
                        {
                            if (i < listNeed.Items.Count-1)
                            {
                                needBox += ($"{listNeed.Items[i]}|");
                            }
                            else if (i == listNeed.Items.Count-1)
                            {
                                needBox += ($"{listNeed.Items[i]}");
                            }
                        }
                        for (int i = 0; i < listHave.Items.Count; i++)
                        {
                            if (i < listHave.Items.Count-1)
                            {
                                HaveBox += ($"{listHave.Items[i]}|");
                            }
                            else if (i == listHave.Items.Count-1) 
                            {
                                HaveBox += ($"{listHave.Items[i]}");
                            }
                        }

                        saveString = needBox + "#" + HaveBox;



                        files.Write ( saveString );
                    }
                    myStream.Close ( ); // Closes the file
                }
            }
        }
    }
}
