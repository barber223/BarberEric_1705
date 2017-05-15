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
        MySqlConnection conn = new MySqlConnection ( );
        string firstName = "";
        string lastName = "";
        UserInfo info;

        public Form1 ( )
        {
            InitializeComponent ( );
        }

        private void exitToolStripMenuItem_Click ( object sender,EventArgs e )
        {
            Application.Exit ( );
        }

        private void button3_Click ( object sender,EventArgs e )
        {
         
           string phoneNumber;
            string email;
            
           string[] nums = new string[] {"1","2","3","4","5","6","7","8","9","0" };
            ListViewItem lv = new ListViewItem ( );
            UserInfo data = new UserInfo ( );

            for (int i = 0; i < nums.Length; i++)
            {

                if (string.IsNullOrWhiteSpace ( txtFirstName.Text ) || txtFirstName.Text.Contains ( nums[i] ))
                {
                    MessageBox.Show ( "Please don't enter numbers" );
                    break;
                }
                if (i == nums.Length-1)
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
                if (i == nums.Length-1)
                {
                    lastName = txtLastName.Text;
                }

            }
            string Name = firstName + " " + lastName;

            lv.Text = Name;

            int areaCode;
            int first3;
            int last4;

            int.TryParse ( txtArea.Text,out areaCode );
            int.TryParse ( txtPhone1.Text,out first3 );
            int.TryParse ( txtphone2.Text,out last4 );


            phoneNumber = areaCode +" "+ first3 +" "+ last4;

            lv.SubItems.Add ( phoneNumber.ToString() );
            email = txtemail1.Text + "@" + txtemail2.Text + cmbextension.Text;

            lv.SubItems.Add ( email );

            
            lv.ImageIndex = 0;

            lvUsers.Items.Add ( lv );

            ClearInputs ( );


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
        }

        private void button2_Click ( object sender,EventArgs e )
        {
            for (int i = 0; i < lvUsers.Items.Count; i++)
            {
                if (firstName +" "+lastName == lvUsers.Items[i].Text)
                {
                    string phoneNumber;
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

                    int.TryParse ( txtArea.Text,out areaCode );
                    int.TryParse ( txtPhone1.Text,out first3 );
                    int.TryParse ( txtphone2.Text,out last4 );


                    phoneNumber = areaCode + " " + first3 + " " + last4;

                    
                    email = txtemail1.Text + "@" + txtemail2.Text + cmbextension.Text;

                    edit.Text = Name;
                    edit.SubItems.Add ( phoneNumber );
                    edit.SubItems.Add ( email );
                    edit.ImageIndex = 0;

                    lvUsers.Items[i] = edit;

                    ClearInputs ( );
                    
  
                }
            }
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
    }
}
