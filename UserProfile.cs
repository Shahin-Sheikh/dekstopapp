using WindowsFormsApp1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp1
{
    

    public partial class UserProfile : Form
    {

        public static string searchValue;
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        public UserProfile()
        {
            InitializeComponent();

            locationpanel.Visible = false;
        }

       /* private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            profilesetting ins = new profilesetting();
            ins.Show();
            this.Hide();
        }*/

        /*private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Signin ins = new Signin();
            this.Close(); 
            ins.Visible = true;

            this.Hide();
            Signin signin = new Signin();
            signin.Show();
        }*/

        /*private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 ins = new Form9();
            ins.Visible = true;
        }*/

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        /*private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            calander ins = new calander();
            ins.Show();

        }*/

        /*private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }*/

       /* private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            PopupNotifier ins = new PopupNotifier();
            ins.Image = Properties.Resources.msg;
            ins.TitleText = "New Notification";
            ins.ContentText = "Visual studio is hacked";
            ins.Popup();
        }*/

        /*private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            emailsend ins = new emailsend();
            ins.Show();
        }*/

        /*private void src_Click(object sender, EventArgs e)
        {
            string Street = strt.Text;
            string City = city.Text;
            string State = state.Text;
            string Zip = zip.Text;
            try
            {
                StringBuilder queryadd = new StringBuilder();
                queryadd.Append("https://www.google.com/maps/@23.7747523,90.3654215,15z");

                if(Street != string.Empty) 
                {
                    queryadd.Append(Street + "," + "+");
                }
                if (City != string.Empty)
                {
                    queryadd.Append(City + "," + "+");
                }
                if (State != string.Empty)
                {
                    queryadd.Append(State + "," + "+");
                }
                if (Zip != string.Empty)
                {
                    queryadd.Append(Zip + "," + "+");
                }
                webBrowser1.Navigate(queryadd.ToString());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }*/

        /*private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            showacc ins = new showacc();
            ins.Show();
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = false;
        }*/




        private void btnProfileSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilesetting profSetting = new profilesetting();
            profSetting.Show();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signin = new Signin();
            signin.Show();
        }

        private void pcbSearch_Click(object sender, EventArgs e)
        {
            /*string NID = txtSearch.Text;
            string query = "Select * From GeneralUserInfo Where NationalID='" + NID + "'";
            /*SqlCommand searchCommand = new SqlCommand(query);
            objDBAccess.executeQuery(searchCommand);
            objDBAccess.closeConn();
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if(dtUsers.Rows.Count==1)
            {
                this.Hide();
                SearchResult sr = new SearchResult();
                sr.Show();

                //Form9 f9 = new Form9();
                //f9.Show();
            }*/


            this.Hide();
            SearchResult sr = new SearchResult();
            sr.Show();

            /*this.Hide();
            Form9 f9 = new Form9();
            f9.Show();*/
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            calander caln = new calander();
            caln.Show();
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }

        private void pcbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void pcbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void pcbGoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void btnMessageSend_Click(object sender, EventArgs e)
        {
            emailsend emailsnd = new emailsend();
            emailsnd.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            PopupNotifier popupN = new PopupNotifier();
            popupN.Image = Properties.Resources.msg;
            popupN.TitleText = "New Notification";
            popupN.ContentText = "Visual studio is hacked";
            popupN.Popup();
        }

        private void btnSearchLocation_Click(object sender, EventArgs e)
        {
            string Street = strt.Text;
            string City = city.Text;
            string State = state.Text;
            string Zip = zip.Text;
            try
            {
                StringBuilder queryadd = new StringBuilder();
                queryadd.Append("https://www.google.com/maps/@23.7747523,90.3654215,15z");

                if (Street != string.Empty)
                {
                    queryadd.Append(Street + "," + "+");
                }
                if (City != string.Empty)
                {
                    queryadd.Append(City + "," + "+");
                }
                if (State != string.Empty)
                {
                    queryadd.Append(State + "," + "+");
                }
                if (Zip != string.Empty)
                {
                    queryadd.Append(Zip + "," + "+");
                }
                webBrowser1.Navigate(queryadd.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void btnLoaction_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            showacc showAccount = new showacc();
            showAccount.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            locationpanel.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayProfile dsProfile = new DisplayProfile();
            dsProfile.Show();
        }
    }

       
 }
