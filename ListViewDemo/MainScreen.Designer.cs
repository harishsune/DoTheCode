namespace ListViewDemo
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TreePanel = new System.Windows.Forms.Panel();
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFiles = new System.Windows.Forms.PictureBox();
            this.BtnEmail = new System.Windows.Forms.PictureBox();
            this.BtnSQL = new System.Windows.Forms.PictureBox();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.TreePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreePanel
            // 
            this.TreePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.TreePanel.Controls.Add(this.treeListView);
            this.TreePanel.Location = new System.Drawing.Point(94, 17);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(247, 553);
            this.TreePanel.TabIndex = 1;
            // 
            // treeListView
            // 
            this.treeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.treeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeListView.CellEditUseWholeCell = false;
            this.treeListView.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeListView.GridLines = true;
            this.treeListView.HideSelection = false;
            this.treeListView.Location = new System.Drawing.Point(-1, 12);
            this.treeListView.Name = "treeListView";
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(245, 554);
            this.treeListView.TabIndex = 3;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            this.treeListView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.treeListView_CellClick);
            this.treeListView.Click += new System.EventHandler(this.treeListView_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(206, 25);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Interface Testing Utility";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnFiles);
            this.panel1.Controls.Add(this.BtnEmail);
            this.panel1.Controls.Add(this.BtnSQL);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnLogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 569);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 539);
            this.panel2.TabIndex = 13;
            // 
            // BtnFiles
            // 
            this.BtnFiles.Image = global::ListViewDemo.Properties.Resources.file_folder_icon;
            this.BtnFiles.Location = new System.Drawing.Point(9, 353);
            this.BtnFiles.Name = "BtnFiles";
            this.BtnFiles.Size = new System.Drawing.Size(75, 58);
            this.BtnFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnFiles.TabIndex = 4;
            this.BtnFiles.TabStop = false;
            // 
            // BtnEmail
            // 
            this.BtnEmail.Image = global::ListViewDemo.Properties.Resources.mail_flat;
            this.BtnEmail.Location = new System.Drawing.Point(9, 272);
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.Size = new System.Drawing.Size(75, 58);
            this.BtnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEmail.TabIndex = 3;
            this.BtnEmail.TabStop = false;
            // 
            // BtnSQL
            // 
            this.BtnSQL.Image = global::ListViewDemo.Properties.Resources.db;
            this.BtnSQL.Location = new System.Drawing.Point(9, 197);
            this.BtnSQL.Name = "BtnSQL";
            this.BtnSQL.Size = new System.Drawing.Size(75, 58);
            this.BtnSQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSQL.TabIndex = 2;
            this.BtnSQL.TabStop = false;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Image = global::ListViewDemo.Properties.Resources.lifesaver_flat;
            this.BtnHelp.Location = new System.Drawing.Point(9, 115);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(75, 58);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 1;
            this.BtnHelp.TabStop = false;
            // 
            // BtnLogo
            // 
            this.BtnLogo.Image = global::ListViewDemo.Properties.Resources._148795;
            this.BtnLogo.Location = new System.Drawing.Point(9, 33);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(75, 58);
            this.BtnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLogo.TabIndex = 0;
            this.BtnLogo.TabStop = false;
            this.BtnLogo.Click += new System.EventHandler(this.BtnLogo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1009, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(57, 27);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(948, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(57, 27);
            this.BtnMinimize.TabIndex = 5;
            this.BtnMinimize.Text = "__";
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.contactUs,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 70);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactUs
            // 
            this.contactUs.Name = "contactUs";
            this.contactUs.Size = new System.Drawing.Size(177, 22);
            this.contactUs.Text = "Contact Developers";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.titlePanel.Controls.Add(this.LblUserName);
            this.titlePanel.Controls.Add(this.LblTitle);
            this.titlePanel.Location = new System.Drawing.Point(1, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1072, 27);
            this.titlePanel.TabIndex = 9;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(861, 8);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(22, 15);
            this.LblUserName.TabIndex = 10;
            this.LblUserName.Text = "Hi ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListViewDemo.Properties.Resources.colorful_abstract_logo_with_letter_h_1017_1621;
            this.pictureBox1.Location = new System.Drawing.Point(482, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 294);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.panelFooter.Location = new System.Drawing.Point(-4, 568);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1075, 2);
            this.panelFooter.TabIndex = 11;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(88)))), ((int)(((byte)(189)))));
            this.panelRight.Location = new System.Drawing.Point(1063, 28);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2, 541);
            this.panelRight.TabIndex = 12;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 572);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.TreePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.TreePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TreePanel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        
       
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUs;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        
        private BrightIdeasSoftware.TreeListView treeListView;
        private System.Windows.Forms.PictureBox BtnLogo;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.PictureBox BtnSQL;
        private System.Windows.Forms.PictureBox BtnEmail;
        private System.Windows.Forms.PictureBox BtnFiles;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel2;
    }
}

