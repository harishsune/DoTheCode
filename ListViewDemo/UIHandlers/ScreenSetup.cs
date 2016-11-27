using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListViewDemo.UIHandlers
{
    class ScreenSetup
    {
        
        //Batch Controls
        private static TableLayoutPanel DynamicTableLayout;
        private static TextBox txtProcessingLog;
        private static TextBox txtResult;
        private static TextBox txtFTP;
        private static Button btnProcess;
        private static Label LblInterfaceName;
        private static Label lblFTPLocation;
        private static Label lblProcessingLog;
        private static Label lblResult;
        private static Label LblSummary;
        private static bool IsControlsLoaded = false;
        private static bool IsBatchControls = false;
        
        //Webservice
        private static TableLayoutPanel WebServiceLayout;
        private static TextBox txtRequest;
        private static TextBox txtResponse;
        private static TextBox txtURL;
        private static Label LblURL;
        private static Label LblRequest;
        private static Label LblResponse;
        private static Button btnSendRequest;
        private static bool IsWebServiceControl = false;


        public static void SetToNewPosition()
        {
            if (IsControlsLoaded&& IsBatchControls)
            {
                DynamicTableLayout.Width = 900;
                DynamicTableLayout.Location = new Point(150, 82);

                txtProcessingLog.Width = 900;
                txtResult.Width = 900;
                txtFTP.Size = new Size(780, 20);

                LblInterfaceName.Location = new Point(150, 34);
                LblSummary.Location = new Point(350, 45);
            }
            else if (IsControlsLoaded && IsWebServiceControl)

            {
                WebServiceLayout.Width = 900;
                WebServiceLayout.Location = new Point(150, 67);
                LblInterfaceName.Location = new Point(150, 34);
                txtRequest.Size = new Size(400, 390);
                txtResponse.Size = new Size(400, 390);
                txtURL.Size = new Size(700, 23);
            }
        }

        public static void SetToOldPosition()
        {

            if (IsControlsLoaded && IsBatchControls)
            {
                DynamicTableLayout.Width = 718;
                DynamicTableLayout.Location = new Point(347, 82);

                txtProcessingLog.Width = 705;
                txtResult.Width = 705;
                txtFTP.Size = new Size(600, 20);

                LblInterfaceName.Location = new Point(349, 34);
                LblSummary.Location = new Point(525, 45);
            }
            else if(IsControlsLoaded && IsWebServiceControl)
            {
                WebServiceLayout.Width = 710;
                WebServiceLayout.Location = new Point(354, 67);
                LblInterfaceName.Location = new Point(349, 34);
                txtRequest.Size = new Size(305, 390);
                txtResponse.Size = new Size(305, 390);
                txtURL.Size = new Size(566, 23);
            }
        }

        public static void AddBatchLayout(Control.ControlCollection oCollection)
        {
            if (!oCollection.ContainsKey("DynamicTableLayout"))
            {
                IsBatchControls = true;
                IsWebServiceControl = false;

                DynamicTableLayout = new TableLayoutPanel();
                txtResult = new TextBox();
                txtProcessingLog = new TextBox();
                txtFTP = new TextBox();
                lblProcessingLog = new Label();
                lblFTPLocation = new Label();
                lblResult = new Label();
                btnProcess = new Button();
                LblInterfaceName = new Label();
                LblSummary = new Label();
                // 
                // DynamicTableLayout
                // 
                DynamicTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                DynamicTableLayout.Location = new Point(0, 0);
                DynamicTableLayout.Name = "DynamicTableLayout";
                DynamicTableLayout.Size = new Size(200, 100);
                DynamicTableLayout.TabIndex = 9;
                // 
                // txtResult
                // 
                txtResult.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtResult.Location = new Point(3, 268);
                txtResult.Multiline = true;
                txtResult.Name = "txtResult";
                txtResult.Size = new Size(705, 164);
                txtResult.TabIndex = 4;
                txtResult.ScrollBars = ScrollBars.Both;
                // 
                // txtProcessingLog
                // 
                txtProcessingLog.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtProcessingLog.Location = new Point(3, 65);
                txtProcessingLog.Multiline = true;
                txtProcessingLog.Name = "txtProcessingLog";
                txtProcessingLog.ReadOnly = true;
                txtProcessingLog.Size = new Size(705, 151);
                txtProcessingLog.TabIndex = 1;
                txtProcessingLog.ScrollBars = ScrollBars.Both;
                // 
                // txtFTP
                // 
                txtFTP.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtFTP.Location = new Point(45, 3);
                txtFTP.Name = "txtFTP";
                txtFTP.Size = new Size(600, 23);
                txtFTP.TabIndex = 5;
                txtFTP.Text = "ftp://";
                txtFTP.Anchor = AnchorStyles.Top;

                // 
                // label2
                // 
                lblProcessingLog.AutoSize = true;
                lblProcessingLog.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblProcessingLog.ForeColor = Color.DimGray;
                lblProcessingLog.Location = new Point(3, 32);
                lblProcessingLog.Name = "lblProcessingLog";
                lblProcessingLog.Size = new Size(87, 20);
                lblProcessingLog.TabIndex = 2;
                lblProcessingLog.Text = "Process Log";
                lblProcessingLog.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // label1
                // 
                lblFTPLocation.AutoSize = true;
                lblFTPLocation.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblFTPLocation.ForeColor = Color.DimGray;
                lblFTPLocation.Location = new Point(3, 0);
                lblFTPLocation.Name = "lblFTPLocation";
                lblFTPLocation.Size = new Size(80, 20);
                lblFTPLocation.TabIndex = 0;
                lblFTPLocation.Text = "FTP Location";
                lblFTPLocation.Anchor = AnchorStyles.Left;
                lblFTPLocation.Margin = new Padding(3, 0, 3, 0);
                // 
                // label3
                // 
                lblResult.AutoSize = true;
                lblResult.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblResult.ForeColor = Color.DimGray;
                lblResult.Location = new Point(3, 235);
                lblResult.Name = "lblResult";
                lblResult.Size = new Size(49, 20);
                lblResult.TabIndex = 3;
                lblResult.Text = "Result";
                // 
                // btnProcess
                // 
                btnProcess.BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
                btnProcess.FlatStyle = FlatStyle.Flat;
                btnProcess.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnProcess.ForeColor = Color.DimGray;
                btnProcess.Location = new Point(3, 450);
                btnProcess.Name = "btnProcess";
                btnProcess.Size = new Size(95, 29);
                btnProcess.TabIndex = 6;
                btnProcess.Text = "Process";
                btnProcess.UseVisualStyleBackColor = false;
                btnProcess.Click += new System.EventHandler(btnProcess_Click_1);
                // 
                // LblInterfaceName
                // 
                LblInterfaceName.AutoSize = true;
                LblInterfaceName.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblInterfaceName.ForeColor = Color.DimGray;
                LblInterfaceName.Location = new Point(349, 34);
                LblInterfaceName.Name = "LblInterfaceName";
                LblInterfaceName.Size = new Size(157, 30);
                LblInterfaceName.TabIndex = 3;
                LblInterfaceName.Text = "Demo Interface";
                // 
                // LblSummary
                // 
                LblSummary.AutoSize = true;
                LblSummary.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblSummary.ForeColor = Color.DimGray;
                LblSummary.Location = new Point(525, 45);
                LblSummary.Name = "LblSummary";
                LblSummary.Size = new Size(56, 15);
                LblSummary.TabIndex = 8;
                LblSummary.Text = "Summary";

                // 
                // DynamicTableLayout
                // 
                DynamicTableLayout.ColumnCount = 4;
                DynamicTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                //   DynamicTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
                // DynamicTableLayout.ColumnStyles.Add(new ColumnStyle());
                //  DynamicTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));

                DynamicTableLayout.Controls.Add(txtResult, 0, 5);
                DynamicTableLayout.SetColumnSpan(txtResult, 3);
                DynamicTableLayout.SetRowSpan(txtResult, 1);

                DynamicTableLayout.Controls.Add(txtProcessingLog, 0, 3);
                DynamicTableLayout.SetColumnSpan(txtProcessingLog, 3);
                DynamicTableLayout.SetRowSpan(txtProcessingLog, 1);

                DynamicTableLayout.Controls.Add(txtFTP, 1, 0);
                DynamicTableLayout.SetColumnSpan(txtFTP, 2);
                DynamicTableLayout.SetRowSpan(txtFTP, 1);

                DynamicTableLayout.Controls.Add(lblFTPLocation, 0, 0);
                DynamicTableLayout.SetColumnSpan(lblFTPLocation, 2);
                DynamicTableLayout.SetRowSpan(lblFTPLocation, 1);

                DynamicTableLayout.Controls.Add(lblProcessingLog, 0, 2);
                DynamicTableLayout.SetColumnSpan(lblProcessingLog, 2);
                DynamicTableLayout.SetRowSpan(lblProcessingLog, 1);

                DynamicTableLayout.Controls.Add(lblResult, 0, 4);
                DynamicTableLayout.SetColumnSpan(lblResult, 2);
                DynamicTableLayout.SetRowSpan(lblResult, 1);

                DynamicTableLayout.Controls.Add(btnProcess, 0, 6);
                DynamicTableLayout.SetColumnSpan(btnProcess, 2);
                DynamicTableLayout.SetRowSpan(btnProcess, 1);

                DynamicTableLayout.Location = new Point(347, 82);
                DynamicTableLayout.Name = "DynamicTableLayout";
                DynamicTableLayout.RowCount = 7;
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 54.65116F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 42F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
                DynamicTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
                DynamicTableLayout.Size = new Size(718, 488);
                DynamicTableLayout.AutoSizeMode = AutoSizeMode.GrowOnly;
                DynamicTableLayout.TabIndex = 6;
            //  DynamicTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                oCollection.Add(LblInterfaceName);
                oCollection.Add(LblSummary);
                oCollection.Add(DynamicTableLayout);
                DynamicTableLayout.ResumeLayout(false);
                DynamicTableLayout.PerformLayout();
            }

            IsControlsLoaded = true;
        }

        public static void AddWebSeriveLayout(Control.ControlCollection oCollection)
        {
            if (!oCollection.ContainsKey("WebServiceLayout"))
            {
                IsWebServiceControl = true;
                IsBatchControls = false;
                //Creating instance
                WebServiceLayout = new TableLayoutPanel();
                txtRequest = new TextBox();
                txtResponse = new TextBox();
                txtURL = new TextBox();
                LblURL = new Label();
                LblRequest = new Label();
                LblResponse = new Label();
                btnSendRequest = new Button();
                LblInterfaceName = new Label();

                WebServiceLayout.SuspendLayout();

                // 
                // LblInterfaceName
                // 
                LblInterfaceName.AutoSize = true;
                LblInterfaceName.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblInterfaceName.ForeColor = Color.DimGray;
                LblInterfaceName.Location = new Point(349, 34);
                LblInterfaceName.Name = "LblInterfaceName";
                LblInterfaceName.Size = new Size(157, 30);
                LblInterfaceName.TabIndex = 3;
                LblInterfaceName.Text = "Demo Interface";


                // 
                // WebServiceLayout
                // 
                WebServiceLayout.ColumnCount = 4;
                WebServiceLayout.ColumnStyles.Add(new ColumnStyle());
                WebServiceLayout.ColumnStyles.Add(new ColumnStyle());
                WebServiceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                WebServiceLayout.ColumnStyles.Add(new ColumnStyle());
                WebServiceLayout.Controls.Add(txtRequest, 1, 3);
                WebServiceLayout.Controls.Add(txtResponse, 3, 3);
                WebServiceLayout.Controls.Add(txtURL, 1, 1);
                WebServiceLayout.Controls.Add(LblURL, 0, 1);
                WebServiceLayout.Controls.Add(LblRequest, 1, 2);
                WebServiceLayout.Controls.Add(LblResponse, 3, 2);
                WebServiceLayout.Controls.Add(btnSendRequest, 1, 4);
                WebServiceLayout.Location = new Point(354, 67);
                WebServiceLayout.Name = "WebServiceLayout";
                WebServiceLayout.RowCount = 5;
                WebServiceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.24735F));
                WebServiceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
                WebServiceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                WebServiceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 407F));
                WebServiceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 89.75265F));
                WebServiceLayout.Size = new Size(701, 493);
                WebServiceLayout.TabIndex = 10;

                // 
                // txtRequest
                // 
                txtRequest.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtRequest.Location = new Point(56, 57);
                txtRequest.Multiline = true;
                txtRequest.Name = "txtRequest";
                txtRequest.ScrollBars = ScrollBars.Both;
                txtRequest.Size = new Size(305, 390);
                txtRequest.TabIndex = 0;

                // 
                // txtResponse
                // 
                txtResponse.BackColor = Color.White;
                txtResponse.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtResponse.Location = new Point(387, 57);
                txtResponse.Multiline = true;
                txtResponse.Name = "txtResponse";
                txtResponse.ReadOnly = true;
                txtResponse.ScrollBars = ScrollBars.Both;
                txtResponse.Size = new Size(305, 390);
                txtResponse.TabIndex = 1;

                // 
                // txtURL
                // 
                txtURL.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtURL.AutoCompleteSource = AutoCompleteSource.HistoryList;
                WebServiceLayout.SetColumnSpan(txtURL, 3);
                txtURL.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtURL.Location = new Point(56, 6);
                txtURL.Name = "txtURL";
                txtURL.Size = new Size(566, 23);
                txtURL.TabIndex = 2;
                txtURL.Text = "http://";

                // 
                // LblURL
                // 
                LblURL.Anchor = AnchorStyles.Right;
                LblURL.AutoSize = true;
                LblURL.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblURL.ForeColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
                LblURL.Location = new Point(3, 4);
                LblURL.Name = "LblURL";
                LblURL.Size = new Size(47, 28);
                LblURL.TabIndex = 3;
                LblURL.Text = "URL";

                // 
                // LblRequest
                // 
                LblRequest.AutoSize = true;
                LblRequest.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblRequest.ForeColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
                LblRequest.Location = new Point(56, 34);
                LblRequest.Name = "LblRequest";
                LblRequest.Size = new Size(72, 15);
                LblRequest.TabIndex = 4;
                LblRequest.Text = "Request Box";

                // 
                // LblResponse
                // 
                LblResponse.AutoSize = true;
                LblResponse.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                LblResponse.ForeColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
                LblResponse.Location = new Point(387, 34);
                LblResponse.Name = "LblResponse";
                LblResponse.Size = new Size(80, 15);
                LblResponse.TabIndex = 5;
                LblResponse.Text = "Response Box";

                // 
                // btnSendRequest
                // 
                btnSendRequest.FlatStyle = FlatStyle.Flat;
                btnSendRequest.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnSendRequest.ForeColor = Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
                btnSendRequest.Location = new Point(56, 464);
                btnSendRequest.Name = "btnSendRequest";
                btnSendRequest.Size = new Size(96, 23);
                btnSendRequest.TabIndex = 6;
                btnSendRequest.Text = "Send Request";
                btnSendRequest.UseVisualStyleBackColor = true;

                oCollection.Add(WebServiceLayout);
                oCollection.Add(LblInterfaceName);

                WebServiceLayout.ResumeLayout(false);
                WebServiceLayout.PerformLayout();
              
            }
            IsControlsLoaded = true;
        }
        private static void btnProcess_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

