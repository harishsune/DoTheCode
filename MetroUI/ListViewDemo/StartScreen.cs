using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = false;
            txtWorking.Visible = false;   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value != 100)
            {

                circularProgressBar1.Value++;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MainScreen oMainScreen = new MainScreen();
                this.Hide();
                oMainScreen.Show();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txtWorking.Text.Length==18)
            {
                txtWorking.Text = "Working on it";
            }
            else { 
            txtWorking.Text += ".";
            }
        }
        private void txtWorking_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            txtWorking.Visible = true;

            timer1.Enabled = true;
            timer1.Start();
            timer2.Start();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Value = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
    }
}
