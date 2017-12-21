namespace Canvas
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton16 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Due2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton11 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton12 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton13 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton14 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Assignment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Scored = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Due = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton15 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(935, 40);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Controls.Add(this.materialRaisedButton16);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(903, 376);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Calendar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton16
            // 
            this.materialRaisedButton16.Depth = 0;
            this.materialRaisedButton16.Location = new System.Drawing.Point(6, 6);
            this.materialRaisedButton16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton16.Name = "materialRaisedButton16";
            this.materialRaisedButton16.Primary = true;
            this.materialRaisedButton16.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton16.TabIndex = 9;
            this.materialRaisedButton16.Text = "Load Calendar";
            this.materialRaisedButton16.UseVisualStyleBackColor = true;
            this.materialRaisedButton16.Click += new System.EventHandler(this.materialRaisedButton16_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.DescItem,
            this.Due2});
            this.listView2.Location = new System.Drawing.Point(168, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(729, 364);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Assignment";
            // 
            // DescItem
            // 
            this.DescItem.Text = "Description";
            // 
            // Due2
            // 
            this.Due2.Text = "Due By";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialRaisedButton14);
            this.tabPage4.Controls.Add(this.materialRaisedButton13);
            this.tabPage4.Controls.Add(this.materialRaisedButton12);
            this.tabPage4.Controls.Add(this.materialRaisedButton11);
            this.tabPage4.Controls.Add(this.materialRaisedButton10);
            this.tabPage4.Controls.Add(this.materialRaisedButton9);
            this.tabPage4.Controls.Add(this.materialRaisedButton8);
            this.tabPage4.Controls.Add(this.materialRaisedButton7);
            this.tabPage4.Controls.Add(this.materialRaisedButton6);
            this.tabPage4.Controls.Add(this.materialRaisedButton5);
            this.tabPage4.Controls.Add(this.materialRaisedButton4);
            this.tabPage4.Controls.Add(this.materialRaisedButton3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(903, 376);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Themes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(48, 24);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton3.TabIndex = 0;
            this.materialRaisedButton3.Text = "Red";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(48, 88);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton4.TabIndex = 1;
            this.materialRaisedButton4.Text = "Indigo";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(372, 24);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton5.TabIndex = 2;
            this.materialRaisedButton5.Text = "Yellow";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(372, 88);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton6.TabIndex = 3;
            this.materialRaisedButton6.Text = "Purple";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(534, 24);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton7.TabIndex = 4;
            this.materialRaisedButton7.Text = "Green";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(210, 24);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton8.TabIndex = 5;
            this.materialRaisedButton8.Text = "Orange";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Location = new System.Drawing.Point(210, 88);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton9.TabIndex = 6;
            this.materialRaisedButton9.Text = "Pink";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            this.materialRaisedButton9.Click += new System.EventHandler(this.materialRaisedButton9_Click);
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Location = new System.Drawing.Point(534, 88);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton10.TabIndex = 7;
            this.materialRaisedButton10.Text = "Cyan";
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            this.materialRaisedButton10.Click += new System.EventHandler(this.materialRaisedButton10_Click);
            // 
            // materialRaisedButton11
            // 
            this.materialRaisedButton11.Depth = 0;
            this.materialRaisedButton11.Location = new System.Drawing.Point(696, 24);
            this.materialRaisedButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton11.Name = "materialRaisedButton11";
            this.materialRaisedButton11.Primary = true;
            this.materialRaisedButton11.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton11.TabIndex = 8;
            this.materialRaisedButton11.Text = "Blue";
            this.materialRaisedButton11.UseVisualStyleBackColor = true;
            this.materialRaisedButton11.Click += new System.EventHandler(this.materialRaisedButton11_Click);
            // 
            // materialRaisedButton12
            // 
            this.materialRaisedButton12.Depth = 0;
            this.materialRaisedButton12.Location = new System.Drawing.Point(696, 88);
            this.materialRaisedButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton12.Name = "materialRaisedButton12";
            this.materialRaisedButton12.Primary = true;
            this.materialRaisedButton12.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton12.TabIndex = 9;
            this.materialRaisedButton12.Text = "Teal";
            this.materialRaisedButton12.UseVisualStyleBackColor = true;
            this.materialRaisedButton12.Click += new System.EventHandler(this.materialRaisedButton12_Click);
            // 
            // materialRaisedButton13
            // 
            this.materialRaisedButton13.Depth = 0;
            this.materialRaisedButton13.Location = new System.Drawing.Point(372, 178);
            this.materialRaisedButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton13.Name = "materialRaisedButton13";
            this.materialRaisedButton13.Primary = true;
            this.materialRaisedButton13.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton13.TabIndex = 10;
            this.materialRaisedButton13.Text = "Light";
            this.materialRaisedButton13.UseVisualStyleBackColor = true;
            this.materialRaisedButton13.Click += new System.EventHandler(this.materialRaisedButton13_Click);
            // 
            // materialRaisedButton14
            // 
            this.materialRaisedButton14.Depth = 0;
            this.materialRaisedButton14.Location = new System.Drawing.Point(372, 242);
            this.materialRaisedButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton14.Name = "materialRaisedButton14";
            this.materialRaisedButton14.Primary = true;
            this.materialRaisedButton14.Size = new System.Drawing.Size(156, 58);
            this.materialRaisedButton14.TabIndex = 11;
            this.materialRaisedButton14.Text = "Dark";
            this.materialRaisedButton14.UseVisualStyleBackColor = true;
            this.materialRaisedButton14.Click += new System.EventHandler(this.materialRaisedButton14_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assignments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Assignment,
            this.Scored,
            this.Available,
            this.Due,
            this.Description});
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(891, 340);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Assignment
            // 
            this.Assignment.Text = "Assignment";
            // 
            // Scored
            // 
            this.Scored.Text = "Points Scored";
            // 
            // Available
            // 
            this.Available.Text = "Points Available";
            // 
            // Due
            // 
            this.Due.Text = "Due By";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 349);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(195, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Current Course: None";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton15);
            this.tabPage1.Controls.Add(this.materialCheckBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 176);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(583, 164);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 347);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(196, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "User Name : Unknown";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(595, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(302, 53);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Get Courses";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(595, 61);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(302, 53);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Get Grades";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialCheckBox1.Location = new System.Drawing.Point(595, 310);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(272, 30);
            this.materialCheckBox1.TabIndex = 5;
            this.materialCheckBox1.Text = "Get Assignment Grades (BETA)";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // materialRaisedButton15
            // 
            this.materialRaisedButton15.Depth = 0;
            this.materialRaisedButton15.Location = new System.Drawing.Point(595, 116);
            this.materialRaisedButton15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton15.Name = "materialRaisedButton15";
            this.materialRaisedButton15.Primary = true;
            this.materialRaisedButton15.Size = new System.Drawing.Size(302, 53);
            this.materialRaisedButton15.TabIndex = 6;
            this.materialRaisedButton15.Text = "Unselect Lists";
            this.materialRaisedButton15.UseVisualStyleBackColor = true;
            this.materialRaisedButton15.Click += new System.EventHandler(this.materialRaisedButton15_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(596, 176);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(301, 106);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.DoubleClick += new System.EventHandler(this.checkedListBox1_DoubleClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(591, 285);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(96, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "To-Do List";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 110);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(911, 405);
            this.materialTabControl1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 527);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "    Canvas Assistant";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton15;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Assignment;
        private System.Windows.Forms.ColumnHeader Scored;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.ColumnHeader Due;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton14;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton13;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton12;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton11;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton10;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton9;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader DescItem;
        private System.Windows.Forms.ColumnHeader Due2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton16;
    }
}