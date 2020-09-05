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

namespace WindowsFormsApp1
{
    public partial class Signin : Form
    {
        //MySqlConnection con = new MySqlConnection("datasource = localhost; username = root; password =; database = general");
        public static string id, firstName, lastName, email, phone, presentAddress, permanentAddress, nationalID, dateOfBirth,
            passportNumber, bloodGroup, age, gender, password;

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void pcbLinkedinLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com");
        }

        private void pcbTwitterLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void pcbFacebookLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory cat = new catagory();
            cat.Show();
        }

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Signin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userEmailLogin = txtEmailLogin.Text;
            string userPasswordLogin = txtPasswordLogin.Text;

            if(userEmailLogin.Equals(""))
            {
                MessageBox.Show("Enter your email or phone number");
            }
            else if(userPasswordLogin.Equals(""))
            {
                MessageBox.Show("Enter your password.");
            }
            else
            {
                string query = "Select * From GeneralUserInfo Where Email='" + userEmailLogin + "'AND Password='" + userPasswordLogin + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    firstName = dtUsers.Rows[0]["FirstName"].ToString();
                    lastName = dtUsers.Rows[0]["LastName"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    phone = dtUsers.Rows[0]["Phone"].ToString();
                    presentAddress = dtUsers.Rows[0]["PresentAddress"].ToString();
                    permanentAddress = dtUsers.Rows[0]["PermanetAddress"].ToString();
                    nationalID = dtUsers.Rows[0]["NationalID"].ToString();
                    dateOfBirth = dtUsers.Rows[0]["DateofBirth"].ToString();
                    passportNumber = dtUsers.Rows[0]["PassportNumber"].ToString();
                    bloodGroup = dtUsers.Rows[0]["BloodGruop"].ToString();
                    age = dtUsers.Rows[0]["Age"].ToString();
                    gender = dtUsers.Rows[0]["Gender"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();

                    MessageBox.Show("You are in.");
                    this.Hide();
                    UserProfile f2 = new UserProfile();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Invalid credentials you provide..Try again");
                }

            }
        }
        /*private void Login_Click(object sender, EventArgs e)
{
   int i = 0;
   con.Open();
   MySqlCommand cmd = con.CreateCommand();
   cmd.CommandType=CommandType.Text;
   cmd.CommandText = "select * from information where Email='" + txtEmailLogin.Text + "' and Password = '" + txtPasswordLogin.Text + "'";
   cmd.ExecuteNonQuery();
   DataTable dt = new DataTable();
   MySqlDataAdapter da = new MySqlDataAdapter(cmd);
   da.Fill(dt);
   i = Convert.ToInt32(dt.Rows.Count.ToString());
   if (i == 0) 
   {
       MessageBox.Show("Invalid Email Or Password");
   }
   else 
   {
       this.Hide();
       Form2 ins = new Form2();
       ins.Show();

   }
}
private void button1_Click(object sender, EventArgs e)
{
   this.Hide();

   Form7 obj = new Form7();
   obj.Show();
}

private void button2_Click(object sender, EventArgs e)
{
   catagory ins = new catagory();

   ins.MdiParent = this.MdiParent;
   this.Hide();
   ins.ShowDialog();
}

private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
{
   txtEmailLogin.Text = "";
}

private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
{
   txtPasswordLogin.Text = "";
}

private void pictureBox3_Click(object sender, EventArgs e)
{
   System.Diagnostics.Process.Start("www.facebook.com");
}

private void pictureBox4_Click(object sender, EventArgs e)
{
   System.Diagnostics.Process.Start("www.twitter.com");
}

private void pictureBox5_Click(object sender, EventArgs e)
{
   System.Diagnostics.Process.Start("www.linkedin.com");
} */
    }
}
