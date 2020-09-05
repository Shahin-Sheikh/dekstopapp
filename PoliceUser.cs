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
    public partial class PoliceUser : Form
    {
        //MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DBAccess objDBAccess = new DBAccess();



        public PoliceUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pUserFirstName = txtFirstNameP.Text;
            string pUserLastName = txtLastNameP.Text;
            string pUserEmail = txtEmailP.Text;
            string pUserPhone = txtPhoneP.Text;
            string pUserPoliceID = txtPoliceIDP.Text;
            string pUserRegion = txtRegionP.Text;
            string pUserRank = txtRankP.Text;
            string pUserDateofBirth = dateTimePickerP.Text;
            string pUserNationalID = txtNationalIDP.Text;
            string pUserBloodGroup = txtBloodGroupP.Text;
            string pUserAge = txtAgeP.Text;
            string pUserGender = txtGenderP.Text;
            string pUserPassword = txtPasswordP.Text;

            if (pUserFirstName.Equals(""))
            {
                MessageBox.Show("Please enter your Firsr Name");
            }
            else if (pUserLastName.Equals(""))
            {
                MessageBox.Show("Please enter your Last Name");
            }
            else if (pUserEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }
            else if (pUserPhone.Equals(""))
            {
                MessageBox.Show("Please enter your phone number");
            }
            else if (pUserPoliceID.Equals(""))
            {
                MessageBox.Show("Please enter your police id");
            }

            else if (pUserRegion.Equals(""))
            {
                MessageBox.Show("Please enter your region/area");
            }
            else if (pUserRank.Equals(""))
            {
                MessageBox.Show("Please enter your class");
            }
            else if (pUserDateofBirth.Equals(""))
            {
                MessageBox.Show("Please enter your date of birth");
            }
            else if (pUserNationalID.Equals(""))
            {
                MessageBox.Show("Please enter your NID number");
            }
            else if (pUserBloodGroup.Equals(""))
            {
                MessageBox.Show("Please enter your blood group");
            }
            else if (pUserAge.Equals(""))
            {
                MessageBox.Show("Please enter your age");
            }
            else if (pUserGender.Equals(""))
            {
                MessageBox.Show("Please enter gender");
            }
            else if (pUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                string query = ("insert into PoliceUserInfo(FirstName,LastName,Email,Phone,PoliceID,Area,Rank,DateofBirth,NationalID,BloodGroup,Age,Gender,Password) values(@pUserFirstName,@pUserLastName,@pUserEmail,@pUserPhone,@pUserPoliceID,@pUserRegion,@pUserRank,@pUserDateofBirth,@pUserNationalID,@pUserBloodGroup,@pUserAge,@pUserGender,@pUserPassword)");
                SqlCommand insertCommand = new SqlCommand(query);

                insertCommand.Parameters.AddWithValue("@pUserFirstName", pUserFirstName);
                insertCommand.Parameters.AddWithValue("@pUserLastName", pUserLastName);
                insertCommand.Parameters.AddWithValue("@pUserEmail", pUserEmail);
                insertCommand.Parameters.AddWithValue("@pUserPhone", pUserPhone);
                insertCommand.Parameters.AddWithValue("@pUserPoliceID", pUserPoliceID);
                insertCommand.Parameters.AddWithValue("@pUserRegion", pUserRegion);
                insertCommand.Parameters.AddWithValue("@pUserRank", pUserRank);
                insertCommand.Parameters.AddWithValue("@pUserDateofBirth", pUserDateofBirth);
                insertCommand.Parameters.AddWithValue("@pUserNationalID", pUserNationalID);
                insertCommand.Parameters.AddWithValue("@pUserBloodGroup", pUserBloodGroup);
                insertCommand.Parameters.AddWithValue("@pUserAge", pUserAge);
                insertCommand.Parameters.AddWithValue("@pUserGender", pUserGender);
                insertCommand.Parameters.AddWithValue("@pUserPassword", pUserPassword);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created successfully.Please log in now");
                    this.Hide();
                    Signin f1 = new Signin();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("All fields are mandatory.Try Again");
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory cat = new catagory();
            cat.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        /*private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            //studentform ins = new studentform();
            //ins.Show();
            catagory cat = new catagory();
            cat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO general.police(`First Name`, `Last Name`, `Email`, `Phone`, `Police Id`, `Region`, `Rank`, `Date Of Birth`, `National Id`, `Blood Group`, `Age`, `Gender`, `Password`) VALUES('" + textBox10.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'," + textBox13.Text + ")";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your Registration Is Complete");
                }
                else
                {
                    MessageBox.Show("Unsuccesfull");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}
