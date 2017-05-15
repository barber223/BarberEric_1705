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
         
            int phoneNumber;
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


            phoneNumber = areaCode + first3 + last4;

            lv.SubItems.Add ( phoneNumber.ToString() );
            email = txtemail1.Text + "@" + txtemail2.Text + "." + cmbextension.Text;

            lv.SubItems.Add ( email );

            
            lv.ImageIndex = 0;

            lvUsers.Items.Add ( lv );
            



        }

        private void lvUsers_MouseDoubleClick ( object sender,MouseEventArgs e )
        {
            if (lvUsers.SelectedItems[0] != null)
            {
                string name = lvUsers.SelectedItems[0].
            }
        }
    }
}
