using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;


namespace BarberEric_CE02
{
    public partial class Form1 : Form
    {
        /*
        Eric Barber
        Section 00
        DVP03
        CE02
        */

            //created a connection if i wanted to do a sql and installed the packages
        MySqlConnection conn = new MySqlConnection ( );
        string firstName = "";
        string lastName = "";
        UserInfo info;
        int test;
        public Form1 ( )
        {
            InitializeComponent ( );
        }

        private void exitToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            Application.Exit ( );
        }

        private void lvUsers_MouseDoubleClick ( object sender,MouseEventArgs e )
        {
            if (lvUsers.SelectedItems[0] != null)
            {
                string name = lvUsers.SelectedItems[0].Text;
                string[] arrayname = new string[2];
                arrayname = name.Split ( ' ' );
                txtFirstName.Text = arrayname[0];
                txtLastName.Text = arrayname[1];

                //subitem 1 is the phone number
                string number = lvUsers.SelectedItems[0].SubItems[1].Text;

                string[] arraynumber = new string[3];
                arraynumber = number.Split ( ' ' );
                txtArea.Text = arraynumber[0];
                txtPhone1.Text = arraynumber[1];
                txtphone2.Text = arraynumber[2];
                
                //sub item 2 is the email
                string email = lvUsers.SelectedItems[0].SubItems[2].Text;

                string[] arrayEmail = new string[5];
                char[] splitType =new char [2]{ '@' , '.'};

                try {
                    arrayEmail = email.Split ( splitType );

                    txtemail1.Text = arrayEmail[0];
                    txtemail2.Text = arrayEmail[1];
                    if (arrayEmail[2] == "net")
                    {
                        cmbextension.Text = ".net";
                    }
                    else if (arrayEmail[2] == "com")
                    {
                        cmbextension.Text = ".com";
                    }
                    else if (arrayEmail[2] == "edu")
                    {
                        cmbextension.Text = ".edu";
                    }
                }
                catch(Exception r )
                {
                    MessageBox.Show ( "Email could not be loaded: {0}", r.ToString() );
                }


            }
        }

        private void button2_Click ( object sender,EventArgs e )
        {

        }

        private void ClearInputs ( )
        {
            txtArea.Clear ( );
            txtemail1.Clear ( );
            txtemail2.Clear ( );
            txtFirstName.Clear ( );
            txtLastName.Clear ( );
            txtPhone1.Clear ( );
            txtphone2.Clear ( );
        }

        private void button1_Click ( object sender,EventArgs e )
        {
            if (lvUsers.SelectedItems[0]!= null)
            {
                // have to remove the item
                lvUsers.Items.Remove ( lvUsers.SelectedItems[0] );

            }
        }

        private void largeToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            if (largeToolStripMenuItem.Checked != true)
            {
                largeToolStripMenuItem.Checked = true;
                smallToolStripMenuItem.Checked = false;
                lvUsers.View = View.LargeIcon;
            }
            else
            {
                MessageBox.Show ( "The larger icon is already being displayed" );
            }
        }

        private void smallToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            if (smallToolStripMenuItem.Checked != true)
            {
                smallToolStripMenuItem.Checked = true;
                largeToolStripMenuItem.Checked = false;
                lvUsers.View = View.SmallIcon;
            }
            else
            {
                MessageBox.Show ( "The small icon is already being displayed" );
            }
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
                        string users = "";
                        //TextWriter files;
                        for (int i = 0; i < lvUsers.Items.Count; i++)
                        {
                            if (i < lvUsers.Items.Count - 1)
                            {
                                 users += lvUsers.Items[i].Text + "|" + lvUsers.Items[i].SubItems[1].ToString() + "|" + lvUsers.Items[i].SubItems[2].ToString() + "#";
                            }
                            else if (i == lvUsers.Items.Count-1)
                            {
                                users += lvUsers.Items[i].Text + "|" + lvUsers.Items[i].SubItems[1].ToString() + "|" + lvUsers.Items[i].SubItems[2].ToString();
                            }
                        }



                         // saved the file into a string format to be able to pul it from thr file properly
                        files.Write ( users );
                    }
                    myStream.Close ( ); // Closes the file
                }
            }
        }
        private bool ValidatePhoneLength ( )
        {
            if (txtArea.TextLength != 3)
            {
               
                MessageBox.Show ( "error within phone number" );
                return false;  
            }
            if (txtPhone1.TextLength != 3)
            {
              
                MessageBox.Show ( "error within phone number" );
                return false;
            }
            if (txtphone2.TextLength != 4)
            {
        
                MessageBox.Show ( "error within phone number" );
                return false;
            }

            return true;
        }

        private void btnAdd_Click ( object sender,EventArgs e )
        {
            bool adding = true;
            while (adding)
            {
                string phoneNumber = "";
                string email;

                string[] nums = new string[] { "1","2","3","4","5","6","7","8","9","0" };
                ListViewItem lv = new ListViewItem ( );
                UserInfo data = new UserInfo ( );

                for (int i = 0; i < nums.Length; i++)
                {

                    if (string.IsNullOrWhiteSpace ( txtFirstName.Text ) || txtFirstName.Text.Contains ( nums[i] ))
                    {
                        MessageBox.Show ( "Please don't enter numbers" );
                        break;
                    }
                    if (i == nums.Length - 1)
                    {
                        firstName = txtFirstName.Text;
                    }

                }
                for (int i = 0; i < nums.Length; i++)
                {

                    if (string.IsNullOrWhiteSpace ( txtLastName.Text ) || txtLastName.Text.Contains ( nums[i] ))
                    {
                        MessageBox.Show ( "Please don't enter numbers" );
                        break;
                    }
                    if (i == nums.Length - 1)
                    {
                        lastName = txtLastName.Text;
                    }

                }
                string Name = firstName + " " + lastName;

                lv.Text = Name;

                int areaCode;
                int first3;
                int last4;


                try
                {

                    int.TryParse ( txtArea.Text,out areaCode );
                    int.TryParse ( txtPhone1.Text,out first3 );
                    int.TryParse ( txtphone2.Text,out last4 );

                    //this checks to see if the phone contains letters for if the above fails then the sum of the equation will be 0
                    if (areaCode + first3 + last4 == 0)
                    {
                        MessageBox.Show ( "Dont add letters within the phone number" );
                        break;
                    }


                    adding = ValidatePhoneLength ( );
                    if (adding == false)
                    {
                        break;
                    }


                    //set the value to a string for saving and adding purposes
                    phoneNumber = areaCode + " " + first3 + " " + last4;
                }
                catch (Exception)
                {
                    MessageBox.Show ( "Somthing went wrong check the phone number" );
                }
                lv.SubItems.Add ( phoneNumber.ToString ( ) );
                email = txtemail1.Text + "@" + txtemail2.Text + cmbextension.Text;

                lv.SubItems.Add ( email );


                lv.ImageIndex = 0;
                try
                {
                    for (int i = 0; i < lvUsers.Items.Count; i++)
                    {
                        if (lvUsers.Items[i].SubItems[1].ToString ( ) == phoneNumber.ToString ( ))
                        {
                            MessageBox.Show ( "user Email already exists please try again" );
                            break;
                        }
                    }

                    lvUsers.Items.Add ( lv );
                    ClearInputs ( );
                }
                catch
                {

                }

                break;

            }
        }

        private void btnEdit_Click ( object sender,EventArgs e )
        {
            bool editing = true;
            while (editing)
            {
                for (int i = 0; i < lvUsers.Items.Count; i++)
                {
                    if (firstName + " " + lastName == lvUsers.Items[i].Text)
                    {
                        string phoneNumber = "";
                        string email;


                        string[] nums = new string[] { "1","2","3","4","5","6","7","8","9","0" };


                        for (int k = 0; k < nums.Length; k++)
                        {

                            if (string.IsNullOrWhiteSpace ( txtFirstName.Text ) || txtFirstName.Text.Contains ( nums[i] ))
                            {
                                MessageBox.Show ( "Please don't enter numbers" );
                                break;
                            }
                            if (k == nums.Length - 1)
                            {
                                firstName = txtFirstName.Text;
                            }

                        }
                        for (int k = 0; k < nums.Length; k++)
                        {

                            if (string.IsNullOrWhiteSpace ( txtLastName.Text ) || txtLastName.Text.Contains ( nums[i] ))
                            {
                                MessageBox.Show ( "Please don't enter numbers" );
                                break;
                            }
                            if (k == nums.Length - 1)
                            {
                                lastName = txtLastName.Text;
                            }

                        }
                        string Name = firstName + " " + lastName;
                        ListViewItem edit = new ListViewItem ( );

                        int areaCode;
                        int first3;
                        int last4;
                        try
                        {
                            int.TryParse ( txtArea.Text,out areaCode );
                            int.TryParse ( txtPhone1.Text,out first3 );
                            int.TryParse ( txtphone2.Text,out last4 );

                            editing = ValidatePhoneLength ( );
                            if (editing == false)
                            {
                                break;
                            }

                            phoneNumber = areaCode + " " + first3 + " " + last4;
                        }
                        catch (Exception r)
                        {
                            MessageBox.Show ( $"Somthing went wrong: {r.ToString ( )}" );
                        }

                        email = txtemail1.Text + "@" + txtemail2.Text + cmbextension.Text;

                        edit.Text = Name;
                        edit.SubItems.Add ( phoneNumber );
                        edit.SubItems.Add ( email );
                        edit.ImageIndex = 0;

                        lvUsers.Items[i] = edit;

                        ClearInputs ( );
                        editing = false;
                        break;

                    }
                }
            }
        }
    }
}
