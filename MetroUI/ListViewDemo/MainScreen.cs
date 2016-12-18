using System;
using System.Drawing;
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
            SizeChanged += Form1_WindowStateTrigger;
        }

        private void Form1_WindowStateTrigger(object sender, EventArgs e)
        {
            SetControls();
        }

        private void SetControls()
        {
            if (WindowState == FormWindowState.Normal)
            {
                metroTextBox5.Size = new Size(308, 398);
                metroTextBox6.Size = new Size(308, 398);
                button1.Location = new Point(338, 247);
            }

            if (WindowState == FormWindowState.Maximized)
            {
                metroTextBox5.Size = new Size(420, 520);
                metroTextBox6.Size = new Size(420, 520);
                button1.Location = new Point(470, 240);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetToolTip(BtnLogo, "Hide/Show Tree");
            SetToolTip(BtnFiles, "Show inbound/outbound files");
            SetToolTip(BtnSQL, "Open SQL");
            SetToolTip(BtnHelp, "Show Help");
            SetToolTip(BtnEmail, "Send Email to Developer team");
            helpProvider1.SetShowHelp(BtnHelp,true);
        }


        private void BtnLogo_Click(object sender, EventArgs e)
        {
            if (TreePanel.Visible)
            {
                TreePanel.Visible = false;
                if (WindowState == FormWindowState.Normal)
                {
                    metroTabControl1.Location = new Point(150, 28);
                    metroTabControl1.Size = new Size(850, 521);
                    this.LblTitle.Location = new System.Drawing.Point(150, 9);
                }
            }
            else
            {
                TreePanel.Visible = true;
                metroTabControl1.Location = new Point(347, 28);
                metroTabControl1.Size = new Size(710, 521);
                this.LblTitle.Location = new System.Drawing.Point(347, 9);
            }
        }


        private void SetToolTip(Control oControl, string caption)
        {
            var oTooltip = new ToolTip();
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

        private void BtnDatabaseInfo_Click(object sender, EventArgs e)
        {
            var oCustomPopup = new CustomPopup();
            oCustomPopup.ShowDialog();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));
        }
    }
}