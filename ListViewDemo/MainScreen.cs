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

    public partial class MainScreen : Form
    {
        class Node
        {
            public string Name { get; private set; }
            public string Column1 { get; private set; }
            public string Column2 { get; private set; }
            public string Column3 { get; private set; }

            public string Type { get; private set; }
            public List<Node> Children { get; private set; }
            public Node(string name, string col1, string col2, string type = null)
            {
                this.Name = name;
                this.Column1 = col1;
                this.Column2 = col2;
                this.Type = type;
                this.Children = new List<Node>();

            }
        }


        // private fields
        private List<Node> data;
        private static List<string> RootNodes = new List<string>();
        private static Dictionary<string, string> ChildNodes = new Dictionary<string, string>();
        public MainScreen()
        {
            InitializeComponent();
            AddTree();
            InitializeData();
            FillTree();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblUserName.Text += " " + Environment.UserName;
            SetToolTip(BtnLogo, "Hide/Show Tree");
            SetToolTip(BtnFiles, "Show inbound/outbound files");
            SetToolTip(BtnSQL, "Open SQL");
            SetToolTip(BtnHelp, "Show Help");
            SetToolTip(BtnEmail, "Send Email to Developer team");
        }

        private void FillTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var nameCol = new BrightIdeasSoftware.OLVColumn("Name", "Name");
            nameCol.AspectGetter = x => (x as Node).Name;
            nameCol.MinimumWidth = 80;
            var col1 = new BrightIdeasSoftware.OLVColumn("Last Run", "Column1");
            col1.AspectGetter = x => (x as Node).Column1;
            col1.MinimumWidth = 80;
            var col2 = new BrightIdeasSoftware.OLVColumn("History", "Column2");
            col1.AspectGetter = x => (x as Node).Column1;

            // add the columns to the tree
            this.treeListView.Columns.Add(nameCol);
            this.treeListView.Columns.Add(col1);
            this.treeListView.Columns.Add(col2);
            treeListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            treeListView.HotItemStyle = new BrightIdeasSoftware.HotItemStyle();
            treeListView.HotItemStyle.BackColor = Color.White;
            // set the tree roots
            this.treeListView.Roots = data;
            treeListView.BorderStyle = BorderStyle.None;
            foreach (Node rootNode in treeListView.Roots)
            {
                RootNodes.Add(rootNode.Name);
                foreach (Node child in rootNode.Children)
                {
                    ChildNodes.Add(child.Name, child.Type);
                }
            }

        }

        private void InitializeData()
        {

            // create fake nodes
            var parent1 = new Node("Financial", "", "");
            parent1.Children.Add(new Node("Agent Manager", "A", "X", "Batch"));
            parent1.Children.Add(new Node("CHILD_1_2", "A", "Y", "Batch"));
            parent1.Children.Add(new Node("CHILD_1_3", "A", "Z", "Batch"));

            var parent2 = new Node("PARENT2", "", "");
            parent2.Children.Add(new Node("CHILD_2_1", "B", "W", "WebService"));
            parent2.Children.Add(new Node("CHILD_2_2", "B", "Z", "WebService"));
            parent2.Children.Add(new Node("CHILD_2_3", "B", "J", "WebService"));



            data = new List<Node> { parent1, parent2 };
        }

        private void AddTree()
        {
            //treeListView = new BrightIdeasSoftware.TreeListView();
            //treeListView.Height = 490;
            //treeListView.Width = 247;
            //treeListView.Dock = DockStyle.Bottom;
            //treeListView.BorderStyle = BorderStyle.Fixed3D;
            //TreePanel.Controls.Add(treeListView);

        }
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void treeListView_Click(object sender, EventArgs e)
        {

            BrightIdeasSoftware.TreeListView oTreeListView = (BrightIdeasSoftware.TreeListView)sender;
            if (oTreeListView.SelectedItem != null)
            {
                if (ChildNodes.ContainsKey(oTreeListView.SelectedItem.Text))
                {
                    string sInterfaceType;
                    ChildNodes.TryGetValue(oTreeListView.SelectedItem.Text, out sInterfaceType);
                    if (!string.IsNullOrEmpty(sInterfaceType) && sInterfaceType.ToUpper().Equals("BATCH"))
                    {
                        RemoveControls();
                        UIHandlers.ScreenSetup.AddBatchLayout(this.Controls);
                        SetInterfaceName(oTreeListView);
                    }
                    else
                    {
                        RemoveControls();
                        UIHandlers.ScreenSetup.AddWebSeriveLayout(this.Controls);
                        SetInterfaceName(oTreeListView);
                    }
                }
                else
                {

                    RemoveControls();
                }
            }
        }

        private void SetInterfaceName(BrightIdeasSoftware.TreeListView oTreeListView)
        {
            Control[] oControl = this.Controls.Find("LblInterfaceName", false);
            oControl[0].Text = oTreeListView.SelectedItem.Text;
            pictureBox1.Visible = false;
        }

        private void RemoveControls()
        {
            Controls.RemoveByKey("LblInterfaceName");
            Controls.RemoveByKey("DynamicTableLayout");
            Controls.RemoveByKey("WebServiceLayout");
            Controls.RemoveByKey("LblSummary");
            pictureBox1.Visible = true;
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            if (TreePanel.Visible)
            {
                TreePanel.Visible = false;
                UIHandlers.ScreenSetup.SetToNewPosition();
            }
            else
            {
                TreePanel.Visible = true;
                UIHandlers.ScreenSetup.SetToOldPosition();
            }

        }

        private void DynamicTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click_1(object sender, EventArgs e)
        {

        }

        private void treeListView_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {

        }

        private void SetToolTip(Control oControl,string caption)
        {
            ToolTip oTooltip = new ToolTip();
            oTooltip.Tag = caption;
            oTooltip.SetToolTip(oControl, caption);

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

