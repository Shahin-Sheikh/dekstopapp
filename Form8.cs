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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int rowmax = 2000;
            int cowmax = 2000;

            decimal pcdDone;

            for ( int r = 0;r<rowmax;r++ )
            {
                for (int c = 0; c < cowmax; c++)
                {
                    counter++;
                }
                pcdDone = (decimal)counter / (rowmax * cowmax);

                groupBox1.Text = ((int)(pcdDone * 100)).ToString() + "%";
                groupBox1.Refresh();
                label1.Width = Convert.ToInt32(pcdDone * (groupBox1.Width - 10));
            }
            this.Close();
        }
    }
}
