using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26._10._20_ProgressBar__TrackBar
{
    public partial class Form1 : Form
    {
        bool check = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //label2.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == false)
            {
                progressBar1.PerformStep();
            }
 
            if (progressBar1.Value == progressBar1.Maximum && check == false)
            {
                check = true;
                MessageBox.Show("ProgressBar is finished!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            check = false;
        }
    }
}
