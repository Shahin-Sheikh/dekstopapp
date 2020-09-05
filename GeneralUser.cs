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
    public partial class GeneralUser : Form
    {
        DBAccess objDBAccess = new DBAccess();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string gUserFirstName = txtFirstName.Text;
            string gUserLastName = txtLastName.Text;
            string gUserEmail = txtEmail.Text;
            string gUserPhone = txtPhone.Text;
            string gUserPresentAddress = txtPresentAddress.Text;
            string gUserPermanentAddress = txtPermanetAddress.Text;
            string gUserNationalID = txtNationalID.Text;
            string gUserDateofBirth = dateTimePicker1.Text;
            string gUserPassportNumber = txtPassportNumber.Text;
            string gUserBloodGroup = txtBloodGroup.Text;
            string gUserAge = txtAge.Text;
            string gUserGender = txtGender.Text;
            string gUserPassword = txtPassword.Text;

            if (gUserFirstName.Equals(""))
            {
                MessageBox.Show("Please enter your Firsr Name");
            }
            else if (gUserLastName.Equals(""))
            {
                MessageBox.Show("Please enter your Last Name");
            }
            else if (gUserEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }
            else if (gUserPhone.Equals(""))
            {
                MessageBox.Show("Please enter your phone number");
            }
            else if (gUserPresentAddress.Equals(""))
            {
                MessageBox.Show("Please enter your present address");
            }

            else if (gUserPermanentAddress.Equals(""))
            {
                MessageBox.Show("Please enter your Firsr Name");
            }
            else if (gUserNationalID.Equals(""))
            {
                MessageBox.Show("Please enter your NID");
            }
            else if (gUserDateofBirth.Equals(""))
            {
                MessageBox.Show("Please enter your date of birth");
            }
            else if (gUserPassportNumber.Equals(""))
            {
                MessageBox.Show("Please enter your passport number");
            }
            else if (gUserBloodGroup.Equals(""))
            {
                MessageBox.Show("Please enter your blood group");
            }
            else if (gUserAge.Equals(""))
            {
                MessageBox.Show("Please enter your age");
            }
            else if (gUserGender.Equals(""))
            {
                MessageBox.Show("Please enter gender");
            }
            else if (gUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                string query = ("insert into GeneralUserInfo(FirstName,LastName,Email,Phone,PresentAddress,PermanetAddress,NationalID,DateofBirth,PassportNumber,BloodGruop,Age,Gender,Password) values(@gUserFirstName,@gUserLastName,@gUserEmail,@gUserPhone,@gUserPresentAddress,@gUserPermanentAddress,@gUserNationalID,@gUserDateofBirth,@gUserPassportNumber,@gUserBloodGroup,@gUserAge,@gUserGender,@gUserPassword)");
                SqlCommand insertCommand = new SqlCommand(query);

                insertCommand.Parameters.AddWithValue("@gUserFirstName", gUserFirstName);
                insertCommand.Parameters.AddWithValue("@gUserLastName", gUserLastName);
                insertCommand.Parameters.AddWithValue("@gUserEmail", gUserEmail);
                insertCommand.Parameters.AddWithValue("@gUserPhone", gUserPhone);
                insertCommand.Parameters.AddWithValue("@gUserPresentAddress", gUserPresentAddress);
                insertCommand.Parameters.AddWithValue("@gUserPermanentAddress", gUserPermanentAddress);
                insertCommand.Parameters.AddWithValue("@gUserNationalID", gUserNationalID);
                insertCommand.Parameters.AddWithValue("@gUserDateofBirth", gUserDateofBirth);
                insertCommand.Parameters.AddWithValue("@gUserPassportNumber", gUserPassportNumber);
                insertCommand.Parameters.AddWithValue("@gUserBloodGroup", gUserBloodGroup);
                insertCommand.Parameters.AddWithValue("@gUserAge", gUserAge);
                insertCommand.Parameters.AddWithValue("@gUserGender", gUserGender);
                insertCommand.Parameters.AddWithValue("@gUserPassword", gUserPassword);

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
    



        // MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public GeneralUser()
        {
            InitializeComponent();
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
            string insertQuery = "INSERT INTO general.information(`FirstName`, `LastName`, `Email`, `PhoneNo`, `PresentAddress`, `PermanentAddress`, `NationalID`, `DateOfBirth`, `PassportNumber`, `BloodGroup`, `Age`, `Gender`, `Password`) VALUES('" + textBoxfname.Text + "','" + textBoxlname.Text + "','" + textBoxemail.Text + "','" + textBoxphone.Text +  "','" + textBoxpa.Text +  "','" + textBoxpresent.Text +  "','" + textBoxnid.Text +  "','" + dateTimePicker1.Value.Date+  "','" + textBoxpn.Text +  "','" + textBoxbg.Text +  "','" + textBoxage.Text +  "','" + textBoxgender.Text + "'," + textBoxpass.Text + ")";
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            catagory ins = new catagory();
            ins.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }*/
    }
}
