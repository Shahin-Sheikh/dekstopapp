using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class emailsend : Form
    {
        public emailsend()
        {
            InitializeComponent();

            showmsg.Visible = false;

            pass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, sub.Text, msg.Text);

            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(un.Text,pass.Text);

            client.EnableSsl = true;

            client.Send(mail);

            MessageBox.Show("Mail send!", "Success", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showmsg.Visible = true;
        }
    }
}
