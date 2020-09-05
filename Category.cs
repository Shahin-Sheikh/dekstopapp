using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class catagory : Form
    {
        public catagory()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnBunifuFlatGo_Click(object sender, EventArgs e)
        {
            if (rdbGeneral.Checked)
            {
                this.Hide();
                GeneralUser f4 = new GeneralUser();
                f4.Show();

                /*Form1 f1 = new Form1();
                f1.Show();*/

                /*Form4 ins = new Form4();

                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();*/
            }
            if (rdbPolice.Checked)
            {
                this.Hide();
                PoliceUser f6 = new PoliceUser();
                f6.Show();
            }
            if (rdbStudent.Checked)
            {
                this.Hide();
                studentform f5 = new studentform();
                f5.Show();
            }
        }


        /*private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 ins = new Form4();

            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 obj = new Form2();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            studentform obj = new studentform();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Form6 obj = new Form6();

            obj.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 ins = new Form4();
                ins.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Form6 ins = new Form6();
                ins.Show();
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                studentform ins = new studentform();
                ins.Show();
                this.Hide();
            }
        }*/
    }
}
