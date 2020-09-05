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
    public partial class studentform : Form
    {
        //MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        DBAccess objDBAccess = new DBAccess();


        public studentform()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sUserFirstName = txtFirstNameS.Text;
            string sUserLastName = txtLastNameS.Text;
            string sUserEmail = txtEmailS.Text;
            string sUserPhone = txtPhoneS.Text;
            string sUserStudentID = txtStudentIDS.Text;
            string sUserSchool = txtSchoolS.Text;
            string sUserCLass = txtClassS.Text;
            string sUserDateofBirth = dateTimePickerS.Text;
            string sUserNationalID = txtNationalIDS.Text;
            string sUserBloodGroup = txtBloodGroupS.Text;
            string sUserAge = txtAgeS.Text;
            string sUserGender = txtGenderS.Text;
            string sUserPassword = txtPasswordS.Text;

            if (sUserFirstName.Equals(""))
            {
                MessageBox.Show("Please enter your Firsr Name");
            }
            else if (sUserLastName.Equals(""))
            {
                MessageBox.Show("Please enter your Last Name");
            }
            else if (sUserEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }
            else if (sUserPhone.Equals(""))
            {
                MessageBox.Show("Please enter your phone number");
            }
            else if (sUserStudentID.Equals(""))
            {
                MessageBox.Show("Please enter your student id");
            }

            else if (sUserSchool.Equals(""))
            {
                MessageBox.Show("Please enter your school name");
            }
            else if (sUserCLass.Equals(""))
            {
                MessageBox.Show("Please enter your class");
            }
            else if (sUserDateofBirth.Equals(""))
            {
                MessageBox.Show("Please enter your date of birth");
            }
            else if (sUserNationalID.Equals(""))
            {
                MessageBox.Show("Please enter your NID number");
            }
            else if (sUserBloodGroup.Equals(""))
            {
                MessageBox.Show("Please enter your blood group");
            }
            else if (sUserAge.Equals(""))
            {
                MessageBox.Show("Please enter your age");
            }
            else if (sUserGender.Equals(""))
            {
                MessageBox.Show("Please enter gender");
            }
            else if (sUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                string query = ("insert into StudentUserInfo(FirstName,LastName,Email,Phone,StudentID,SchoolName,Class,DateofBirth,NationalID,BloodGruop,Age,Gender,Password) values(@sUserFirstName,@sUserLastName,@sUserEmail,@sUserPhone,@sUserStudentID,@sUserSchool,@sUserCLass,@sUserDateofBirth,@sUserNationalID,@sUserBloodGroup,@sUserAge,@sUserGender,@sUserPassword)");
                SqlCommand insertCommand = new SqlCommand(query);

                insertCommand.Parameters.AddWithValue("@sUserFirstName", sUserFirstName);
                insertCommand.Parameters.AddWithValue("@sUserLastName", sUserLastName);
                insertCommand.Parameters.AddWithValue("@sUserEmail", sUserEmail);
                insertCommand.Parameters.AddWithValue("@sUserPhone", sUserPhone);
                insertCommand.Parameters.AddWithValue("@sUserStudentID", sUserStudentID);
                insertCommand.Parameters.AddWithValue("@sUserSchool", sUserSchool);
                insertCommand.Parameters.AddWithValue("@sUserCLass", sUserCLass);
                insertCommand.Parameters.AddWithValue("@sUserDateofBirth", sUserDateofBirth);
                insertCommand.Parameters.AddWithValue("@sUserNationalID", sUserNationalID);
                insertCommand.Parameters.AddWithValue("@sUserBloodGroup", sUserBloodGroup);
                insertCommand.Parameters.AddWithValue("@sUserAge", sUserAge);
                insertCommand.Parameters.AddWithValue("@sUserGender", sUserGender);
                insertCommand.Parameters.AddWithValue("@sUserPassword", sUserPassword);

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










        /*private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO general.student(`First Name`, `Last Name`, `Email`, `Phone`, `Student Id`, `School`, `Class`, `Date Of Birth`, `National Id`, `Blood Group`, `Age`, `Gender`, `Password`) VALUES('" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox10.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'," + textBox13.Text + ")";
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
        }*/
    }
}
