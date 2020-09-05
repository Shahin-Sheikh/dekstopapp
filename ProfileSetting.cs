using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class profilesetting : Form
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        public profilesetting()
        {
            InitializeComponent();
        }
        
        /*MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='general';username=root;password=");
        MySqlCommand command;

        private void profilesetting_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        public void populateDGV()
        {
            // populate the datagridview
            string selectQuery = "SELECT * FROM information";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        */

       /* private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO information(FirstName, LastName, Age) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")";
            executeMyQuery(insertQuery);
            populateDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE information SET FirstName='" + textBox2.Text + "',LastName='" + textBox3.Text + "',Age=" + textBox4.Text + " WHERE ID =" + int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM information WHERE ID = " + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserProfile ins = new UserProfile();
            ins.Show();
        }*/

        private void profilesetting_Load_1(object sender, EventArgs e)
        {
            string query = "Select * from GeneralUserInfo";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            dataGridView1.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void btnPerformOperation_Click(object sender, EventArgs e)
        {
            string query = "Select * From GeneralUserInfo";
            int changes = objDBAccess.executeDataAdapter(dtUsers, query);
            MessageBox.Show("Changes Count = " + changes);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog==DialogResult.Yes)
            {
                string query = "Delete From GeneralUserInfo Where ID='" + Signin.id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);

                if(row==1)
                {
                    MessageBox.Show("Account deleted.");
                    this.Hide();
                    Signin signin = new Signin();
                    signin.Show();
                }
            }
        }

        private void btnBackProfileSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }
    }
}
