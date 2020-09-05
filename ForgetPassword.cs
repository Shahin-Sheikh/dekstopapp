using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string userEmail = bunifuMaterialTextbox1.Text;
            string userPassword = bunifuMaterialTextbox2.Text;
            string userConfirmPassword = bunifuMaterialTextbox3.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("Enter your email.");
                
            }
            else if(userPassword==userConfirmPassword)
            {
                string query = "Update GeneralUserInfo Set Password='" + @userPassword + "'Where Email='" + userEmail + "'";

                SqlCommand updateCommand = new SqlCommand(query);
                updateCommand.Parameters.AddWithValue("@userPassword", userPassword);
                int row = objDBAccess.executeQuery(updateCommand);

                if(row==1)
                {
                    MessageBox.Show("Password updated.");
                    this.Hide();
                    Signin f1 = new Signin();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Credentials doesn't matched");
                }
                
            }
        }
       

        /*private void bunifuMaterialTextbox1_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox2_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }

        private void bunifuMaterialTextbox3_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }*/
    }
}
