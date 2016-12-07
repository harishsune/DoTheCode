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
using MetroFramework.Forms;

namespace ListViewDemo
{

    public partial class MainScreen : MetroForm
    {
      


        // private fields
       
        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetToolTip(BtnLogo, "Hide/Show Tree");
            SetToolTip(BtnFiles, "Show inbound/outbound files");
            SetToolTip(BtnSQL, "Open SQL");
            SetToolTip(BtnHelp, "Show Help");
            SetToolTip(BtnEmail, "Send Email to Developer team");
        }


        private void BtnLogo_Click(object sender, EventArgs e)
        {
            if (TreePanel.Visible)
            {
                TreePanel.Visible = false;
                if (WindowState == FormWindowState.Normal)
                {
                    metroTabControl1.Location = new Point(150, 28);
                    this.metroTabControl1.Size = new System.Drawing.Size(850, 521);
                }
                else if (WindowState == FormWindowState.Maximized) {

                }
            }
            else
            {
                TreePanel.Visible = true;
                metroTabControl1.Location = new Point(347, 28);
                this.metroTabControl1.Size = new System.Drawing.Size(710, 521);
            }

        }

        

        private void SetToolTip(Control oControl,string caption)
        {
            ToolTip oTooltip = new ToolTip();
            oTooltip.Tag = caption;
            oTooltip.SetToolTip(oControl, caption);

        }

        private void MainScreen_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void MainScreen_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiles_Click(object sender, EventArgs e)
        {
           // metroTabPage2.Hide();
            metroTabControl1.TabPages.Remove(metroTabPage2);
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
           
            metroTabControl1.TabPages.Add(metroTabPage2);
        }
    }
}

