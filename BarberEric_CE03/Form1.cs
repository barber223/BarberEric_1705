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

        string[,] TheBoard = new string[3, 3];
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
            
            if (going == "" || going == "o" && winner == false)
            {
                going = "x";
                btnX.DoDragDrop ( btnX.Text,DragDropEffects.Copy |
               DragDropEffects.Move );
            }

        else if (going =="x" )
            {
                MessageBox.Show ( "Please wait your turn its O's turn" );
            }
            
            
        } 
        private void btnO_MouseDown ( object sender,MouseEventArgs e )
        {
            //This will check to see if there is a winner befor each play and if there is a winner it will kick them befor there allowed to continue player.
            
            if (going == ""||going == "x" && winner == false) {
                going = "o";
                btnO.DoDragDrop ( btnO.Text,DragDropEffects.Copy |
              DragDropEffects.Move );
            }

            else if (going == "o")
            {
                MessageBox.Show ( "Please wait your turn its X's turn" );
            }

        }
        private void ThereWasAwinner ( )
        {

            if (WhoWon == "o")
            {
                score.OWins += 1;
                Owins.Value = score.OWins;
            }
            else if (WhoWon == "x")
            {
                score.XWins += 1;
                Xwins.Value = score.XWins;
            }

            ClearBoard ( );

        }
        private void ClearBoard ( )
        {
            going = "";
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3;k++)
                {
                    TheBoard[i,k] = "";
                }
            }
            winner = false;
        }

        private void btn1_DragDrop ( object sender,DragEventArgs e )
        {if (btn1.BackgroundImage == null)
            {
                if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "x")
                {
                    btn1.BackgroundImage = imageList1.Images[0];
                    TheBoard[0,0] = "x";
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn1.BackgroundImage = imageList1.Images[1];
                    TheBoard[0,0] = "o";
                }
                winner = BoardCheck ( );
               
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
                    TheBoard[1,0] = "x";
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn2.BackgroundImage = imageList1.Images[1];
                    TheBoard[1,0] = "o";
                }
                winner = BoardCheck ( );
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
                    TheBoard[2,0] = "x";
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn3.BackgroundImage = imageList1.Images[1];
                    TheBoard[2,0] = "o";
            }
                winner = BoardCheck ( );
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
                    TheBoard[0,1] = "x";
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn4.BackgroundImage = imageList1.Images[1];
                    TheBoard[0,1] = "o";
            }
                winner = BoardCheck ( );
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
                    TheBoard[1,1] = "x";
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn5.BackgroundImage = imageList1.Images[1];
                    TheBoard[1,1] = "o";
            }
                winner = BoardCheck ( );
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
                    TheBoard[2,1] = "x";
            }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
            {
                btn6.BackgroundImage = imageList1.Images[1];
                    TheBoard[2,1] = "o";
            }
                winner = BoardCheck ( );
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
                    TheBoard[0,2] = "x";
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn7.BackgroundImage = imageList1.Images[1];
                    TheBoard[0,2] = "o";
                }
                winner = BoardCheck ( );
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
                    TheBoard[1,2] = "x";
                }
                else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn8.BackgroundImage = imageList1.Images[1];
                    TheBoard[1,2] = "o";
                }
                winner = BoardCheck ( );
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
                    TheBoard[2,2] = "x";
                }
            else if (e.Data.GetData ( DataFormats.Text ).ToString ( ) == "o")
                {
                    btn9.BackgroundImage = imageList1.Images[1];
                    TheBoard[2,2] = "o";
                }
                winner = BoardCheck ( );
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
            if (TheBoard[0,0] == "x" && TheBoard[1,0] == "x" && TheBoard[2,0] == "x")
            {//first horizontail row
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game");
                return true;
            }
            else if (TheBoard[0,1] == "x" && TheBoard[1,1] == "x" && TheBoard[2,1] == "x")
            {
                //second horizontal row
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,2] == "x" && TheBoard[1,2] == "x" && TheBoard[2,2] == "x")
            {
                //third horizontal row
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,0] == "x" && TheBoard[0,1] == "x" && TheBoard[0,2] == "x")
            {   //first vertical column
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[1,0] == "x" && TheBoard[1,1] == "x" && TheBoard[1,2] == "x")
            {//second vertical column
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[2,0] == "x" && TheBoard[2,1] == "x" && TheBoard[2,2] == "x")
            {//third vertical column
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,0] == "x" && TheBoard[1,1] == "x" && TheBoard[2,2] == "x")
            {
                //right cross downwards
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,2] == "x" && TheBoard[1,1] == "x" && TheBoard[2,0] == "x")
            {
                //cross to the right diagnal upwards
                WhoWon = "x";
                MessageBox.Show ( "X is the winner of this game" );
                return true;
            }


            return false;
        }
            
        private bool CheckO ( )
        { 
            //This checks to see if O wins in any way there for the game will not continue
            if (TheBoard[0,0] == "o" && TheBoard[1,0] == "o" && TheBoard[2,0] == "o")
            {//first horizontail row
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,1] == "o" && TheBoard[1,1] == "o" && TheBoard[2,1] == "o")
            {
                //second horizontal row
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,2] == "o" && TheBoard[1,2] == "o" && TheBoard[2,2] == "o")
            {
                //third horizontal row
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,0] == "o" && TheBoard[0,1] == "o" && TheBoard[0,2] == "o")
            {   //first vertical column
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[1,0] == "o" && TheBoard[1,1] == "o" && TheBoard[1,2] == "o")
            {//second vertical column
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[2,0] == "o" && TheBoard[2,1] == "o" && TheBoard[2,2] == "o")
            {//third vertical column
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,0] == "o" && TheBoard[1,1] == "o" && TheBoard[2,2] == "o")
            {
                //right cross downwards
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }
            else if (TheBoard[0,2] == "o" && TheBoard[1,1] == "o" && TheBoard[2,0] == "o")
            {
                //cross to the right diagnal upwards
                WhoWon = "o";
                MessageBox.Show ( "O is the winner of this game" );
                return true;
            }


            return false;
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
                    ThereWasAwinner ( );
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                ThereWasAwinner ( );
                return true;
            }
            //This will check to see if O wins in any way there for the game will not continue

            

        }



    }
}
