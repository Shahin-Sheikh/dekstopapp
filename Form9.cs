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
    public partial class Form9 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'general'; username = root; password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            searchData1("");
            searchData2("");
            searchData3("");
        }
        public void searchData1(string valueToSearch)
        {
            string query = "SELECT * FROM `information` WHERE CONCAT(`FirstName`, `LastName`, `Email`, `PhoneNo`, `PresentAddress`, `PermanentAddress`, `NationalID`, `DateOfBirth`, `PassportNumber`, `BloodGroup`, `Age`, `Gender`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataview.DataSource = table;
        }
        public void searchData2(string valueToSearch)
        {
            string query = "SELECT * FROM `student` WHERE CONCAT(`First Name`, `Last Name`, `Email`, `Phone`, `Student Id`, `School`, `Class`, `Date Of Birth`, `National Id`, `Blood Group`, `Age`, `Gender`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataview.DataSource = table;
        }
        public void searchData3(string valueToSearch)
        {
            string query = "SELECT * FROM `information` WHERE CONCAT(`First Name`, `Last Name`, `Email`, `Phone`, `Police Id`, `Region`, `Rank`, `Date Of Birth`, `National Id`, `Blood Group`, `Age`, `Gender`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataview.DataSource = table;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string valueToSearch = datasearch.Text.ToString();
            searchData1(valueToSearch);
            searchData2(valueToSearch);
            searchData3(valueToSearch);
        }

        private void datasearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string valueToSearch = datasearch.Text.ToString();
                searchData1(valueToSearch);

            }
        }

        private void datasearch_MouseEnter(object sender, EventArgs e)
        {
            datasearch.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
