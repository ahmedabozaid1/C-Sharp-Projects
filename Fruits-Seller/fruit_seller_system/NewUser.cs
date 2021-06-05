using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_seller_system
{
    public partial class NewUserwindow : Form
    {
        public NewUserwindow()
        {
            InitializeComponent();
        }
        private void AgreecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            createBT.Enabled = true;
        }
        private void createBT_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text != "" && passwordTB.Text != "" && verifyBT.Text != "")
            {
                if (passwordTB.Text == verifyBT.Text)
                {
                    StreamWriter SW = new StreamWriter("users.txt", true);
                    string username = usernameTB.Text;
                    string password = passwordTB.Text;
                    
                        
                    SW.WriteLine(username + "," + password);
                    MessageBox.Show("user created");
                    usernameTB.Text="";
                    passwordTB.Text = "";
                    verifyBT.Text = "";


                    
                    SW.Close();
                }
                else
                {
                    MessageBox.Show("passwords did't matched");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Info");
                usernameTB.Text = "";
                passwordTB.Text = "";
                verifyBT.Text = "";
            }
        }

       
    }
}
