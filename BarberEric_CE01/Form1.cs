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

        Headers header = new Headers ( );
        string[,] needHeader = new string[100, 100];

        


        public GroceryList ( )
        {
            InitializeComponent ( );
        }

        private void btnAdd_Click ( object sender,EventArgs e )
        {
            if (!string.IsNullOrEmpty ( txtItem.Text ))
            {
                listNeed.Items.Add ( txtItem.Text );
                txtItem.Clear ( );
            }
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

                        // this is adding the items from the need list item area.

                        //files.WriteLine ( "*************"+"Need Items"+ "*************\r\n" );

                        //pullThenNedHeaderInfo ( );

                        /*
                        int l = 0;
                        for (int i = 0; i < 7; i++)
                        {
                            for (int k = 0; k < 100; k++)
                            {
                                if (needHeader[i,k].cou)
                                files.Write ( needHeader[i,k] );

                            }
                           
                        }
                        */
                        header.AssignstringToBeCalled ( );

                        for (int i = 0; i < header.Need.Count; i++)
                        {
                            
                            files.WriteLine ( header.Need[i] );
                        }

                        files.Write ( "\r\n" );

                        for (int i = 0; i < listNeed.Items.Count; i++)
                              {

                            if (i == 0 && listNeed.Items != null)
                            {
                                needBox += "<"+listNeed.Items[i]+">"+"\r\n";
                            }
                            else if ( i > 0 && i < listNeed.Items.Count - 1)
                            {
                                needBox += "<"+listNeed.Items[i] + ">\r\n";
                            }
                            

                        }
                        files.WriteLine ( needBox );



                        string itemToPracticeCauseIFeelLikeIAmStupid = "Have Items";
                        files.WriteLine (($"\r\n*************{itemToPracticeCauseIFeelLikeIAmStupid}*************\r\n" ));


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

                        



                        files.Write ( saveString );
                    }
                    myStream.Close ( ); // Closes the file
                }
            }
        }


        private void pullThenNedHeaderInfo ( )
        {

            //needHeader = { { header.A.ToString()}, { header.B.ToString()}, { header.B.ToString()}, { header.} } 
            /*
            int l = 0;
            int innderIndex;
            string[] firstPlace = new string[] {"A"+"B"+"C"+"D"+"E"+"F"+"G" };
            string placeholder = "";
            header.AssignstringToBeCalled ( );


            for (int i = 0; i < header.Need.Count(); i++)
            {
                while (l < header.Need[i].Count ( ))
                {
                    int.TryParse ( header.Need[i][l].ToString ( ),out innderIndex );

                    needHeader[i,l] = header.Need[i][l].ToString ( );

                    /*
                    for (int k = 0; k< header.Need[i].Length; k++)
                    {
                        string placeholder = header.Need[i][k].ToString ( );

                        int.TryParse ( header.Need[i][k].ToString ( ) , out innderIndex);


                        needHeader[i,innderIndex] = header.Need[i][k].ToString ( );
                        l++;
                    }
                    
                    l++;
                }
                
                l = 0;
            }
            */
        }
    }
}
