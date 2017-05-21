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
    public partial class Form1 : Form
    {
        ScoreBoard score = new ScoreBoard ( );

        public Form1 ( )
        {
            InitializeComponent ( );
        }

        bool winner = false;
        string WhoWon = "";
        

        string going = "";

        private void btn1_DragEnter ( object sender,DragEventArgs e )
        {
            if (e.Data.GetDataPresent ( DataFormats.Text ))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void btnX_MouseDown ( object sender,MouseEventArgs e )
        {
            //This will check to see if there is a winner befor each play and if there is a winner it will kick them befor there allowed to continue player.
            winner = BoardCheck ( );
            if (going == "" || going == "o" && winner == false)
            {
                going = "x";
                btnX.DoDragDrop ( btnX.Text,DragDropEffects.Copy |
               DragDropEffects.Move );
            }
        else if (winner == true)
            {
                ThereWasAwinner ( );
            }
        else if (going =="x" )
            {
                MessageBox.Show ( "Please wait your turn its O's turn" );
            }
            
            
        } 
        private void btnO_MouseDown ( object sender,MouseEventArgs e )
        {
            //This will check to see if there is a winner befor each play and if there is a winner it will kick them befor there allowed to continue player.
            winner = BoardCheck ( );
            if (going == ""||going == "x" && winner == false) {
                going = "o";
                btnO.DoDragDrop ( btnO.Text,DragDropEffects.Copy |
              DragDropEffects.Move );
            }
            else if (winner == true)
            {
                ThereWasAwinner ( );
            }
            else if (going == "o")
            {
                MessageBox.Show ( "Please wait your turn its X's turn" );
            }

        }
        private void ThereWasAwinner ( )
        {
            ClearBoard ( );

        }
        private void ClearBoard ( )
        {
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;
        }

        private void btn1_DragDrop ( object sender,DragEventArgs e )
        {if (btn1.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
                {
                    btn1.BackgroundImage = imageList1.Images[0];
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn1.BackgroundImage = imageList1.Images[1];
                }
            }
        else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn2_DragDrop ( object sender,DragEventArgs e )
        {
            if (btn2.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
                {
                    btn2.BackgroundImage = imageList1.Images[0];
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn2.BackgroundImage = imageList1.Images[1];
                }
            }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn3_DragDrop ( object sender,DragEventArgs e )
        {if (btn3.BackgroundImage == null) { 
            if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
            {
                btn3.BackgroundImage = imageList1.Images[0];
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn3.BackgroundImage = imageList1.Images[1];
            }
        }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn4_DragDrop ( object sender,DragEventArgs e )
        {
            if (btn4.BackgroundImage == null) { 
            if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
            {
                btn4.BackgroundImage = imageList1.Images[0];
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn4.BackgroundImage = imageList1.Images[1];
            }
        }

            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn5_DragDrop ( object sender,DragEventArgs e )
        {
            if (btn5.BackgroundImage == null) { 
            if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
            {
                btn5.BackgroundImage = imageList1.Images[0];
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn5.BackgroundImage = imageList1.Images[1];
            }
        }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn6_DragDrop ( object sender,DragEventArgs e )
        {if (btn6.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
            {
                btn6.BackgroundImage = imageList1.Images[0];
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn6.BackgroundImage = imageList1.Images[1];
            }
        }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn7_DragDrop ( object sender,DragEventArgs e )
        {if (btn7.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
                {
                    btn7.BackgroundImage = imageList1.Images[0];
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn7.BackgroundImage = imageList1.Images[1];
                }
            }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn8_DragDrop ( object sender,DragEventArgs e )
        {if (btn8.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
                {
                    btn8.BackgroundImage = imageList1.Images[0];
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn8.BackgroundImage = imageList1.Images[1];
                }
            }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private void btn9_DragDrop ( object sender,DragEventArgs e )
        {
            if (btn9.BackgroundImage == null) {
                if (e.Data.GetData ( DataFormats.Text).ToString ( ) == "x")
            {
                    btn9.BackgroundImage = imageList1.Images[0];
                }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn9.BackgroundImage = imageList1.Images[1];
                }
            }
            else
            {
                if (going == "o")
                {
                    going = "x";
                }
                else if (going == "x")
                {
                    going = "o";
                }
                MessageBox.Show ( "This tile has already been played" );
            }
        }

        private bool CheckX ( )
        {
            //This checks to see if X wins in any way there for the game will not continue
            if (btn1.BackgroundImage == imageList1.Images[0] && btn2.BackgroundImage == imageList1.Images[0] && btn3.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn4.BackgroundImage == imageList1.Images[0] && btn5.BackgroundImage == imageList1.Images[0] && btn6.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn7.BackgroundImage == imageList1.Images[0] && btn8.BackgroundImage == imageList1.Images[0] && btn9.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn1.BackgroundImage == imageList1.Images[0] && btn4.BackgroundImage == imageList1.Images[0] && btn7.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn2.BackgroundImage == imageList1.Images[0] && btn5.BackgroundImage == imageList1.Images[0] && btn8.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn3.BackgroundImage == imageList1.Images[0] && btn6.BackgroundImage == imageList1.Images[0] && btn9.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn1.BackgroundImage == imageList1.Images[0] && btn5.BackgroundImage == imageList1.Images[0] && btn9.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else if (btn3.BackgroundImage == imageList1.Images[0] && btn5.BackgroundImage == imageList1.Images[0] && btn7.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations X wins" );
                WhoWon = "x";
                return true;
            }
            else { return false; }
        }
            
        private bool CheckO ( )
        {
            if (btn1.BackgroundImage == imageList1.Images[1] && btn2.BackgroundImage == imageList1.Images[1] && btn3.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn4.BackgroundImage == imageList1.Images[1] && btn5.BackgroundImage == imageList1.Images[1] && btn6.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn7.BackgroundImage == imageList1.Images[1] && btn8.BackgroundImage == imageList1.Images[1] && btn9.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn1.BackgroundImage == imageList1.Images[1] && btn4.BackgroundImage == imageList1.Images[1] && btn7.BackgroundImage == imageList1.Images[0])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn2.BackgroundImage == imageList1.Images[1] && btn5.BackgroundImage == imageList1.Images[1] && btn8.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn3.BackgroundImage == imageList1.Images[1] && btn6.BackgroundImage == imageList1.Images[1] && btn9.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn1.BackgroundImage == imageList1.Images[1] && btn5.BackgroundImage == imageList1.Images[1] && btn9.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else if (btn3.BackgroundImage == imageList1.Images[1] && btn5.BackgroundImage == imageList1.Images[1] && btn7.BackgroundImage == imageList1.Images[1])
            {
                MessageBox.Show ( "Congratulations O wins" );
                WhoWon = "o";
                return true;
            }
            else { return false; }
        }

        private bool BoardCheck ( )
        {


            bool xOrO;

            xOrO = CheckX ( );
            // if the first check on x is non then the progranm then has to check o
            //if o is either true of false then if will return if there is a winner of not
            // if x is true for a winner then the else statment is to return true for this is no other reason
            //for it to reach the else other wise

            if (xOrO == false)
            {
                xOrO = CheckO ( );
                if (xOrO == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            //This will check to see if O wins in any way there for the game will not continue

            

        }



    }
}
