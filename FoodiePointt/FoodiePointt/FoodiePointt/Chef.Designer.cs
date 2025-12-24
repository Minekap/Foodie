namespace FoodiePointt
{
    partial class Chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            this.pnselect = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnlogout = new System.Windows.Forms.Button();
            this.bnexit = new System.Windows.Forms.Button();
            this.bnfinish = new System.Windows.Forms.Button();
            this.bninventory = new System.Windows.Forms.Button();
            this.bnaccepetorder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.bnprofile = new System.Windows.Forms.Button();
            this.pninventory = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.bndelete = new System.Windows.Forms.Button();
            this.bnupdate = new System.Windows.Forms.Button();
            this.bnenter = new System.Windows.Forms.Button();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbfoodname = new System.Windows.Forms.Label();
            this.dgvinventory = new System.Windows.Forms.DataGridView();
            this.pnfinished = new System.Windows.Forms.Panel();
            this.dgvfinal = new System.Windows.Forms.DataGridView();
            this.cbselectid = new System.Windows.Forms.ComboBox();
            this.bnfinal = new System.Windows.Forms.Button();
            this.pnaccept = new System.Windows.Forms.Panel();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.bnaccept = new System.Windows.Forms.Button();
            this.dgvpendingorder = new System.Windows.Forms.DataGridView();
            this.pncontainer = new System.Windows.Forms.Panel();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.pnselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pninventory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventory)).BeginInit();
            this.pnfinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfinal)).BeginInit();
            this.pnaccept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpendingorder)).BeginInit();
            this.pncontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnselect
            // 
            this.pnselect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnselect.Controls.Add(this.pictureBox1);
            this.pnselect.Controls.Add(this.bnlogout);
            this.pnselect.Controls.Add(this.bnexit);
            this.pnselect.Controls.Add(this.bnfinish);
            this.pnselect.Controls.Add(this.bninventory);
            this.pnselect.Controls.Add(this.bnaccepetorder);
            this.pnselect.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnselect.Location = new System.Drawing.Point(0, 57);
            this.pnselect.Name = "pnselect";
            this.pnselect.Size = new System.Drawing.Size(124, 390);
            this.pnselect.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FoodiePointt.Properties.Resources.Foodiepoint;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FoodiePointt.Properties.Resources.Foodiepoint;
            this.pictureBox1.Location = new System.Drawing.Point(7, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bnlogout
            // 
            this.bnlogout.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnlogout.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnlogout.ForeColor = System.Drawing.Color.Snow;
            this.bnlogout.Location = new System.Drawing.Point(6, 304);
            this.bnlogout.Name = "bnlogout";
            this.bnlogout.Size = new System.Drawing.Size(115, 38);
            this.bnlogout.TabIndex = 12;
            this.bnlogout.Text = "Log out";
            this.bnlogout.UseVisualStyleBackColor = false;
            this.bnlogout.Click += new System.EventHandler(this.bnlogout_Click);
            // 
            // bnexit
            // 
            this.bnexit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnexit.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnexit.ForeColor = System.Drawing.Color.Snow;
            this.bnexit.Location = new System.Drawing.Point(6, 349);
            this.bnexit.Name = "bnexit";
            this.bnexit.Size = new System.Drawing.Size(115, 38);
            this.bnexit.TabIndex = 11;
            this.bnexit.Text = "Exit";
            this.bnexit.UseVisualStyleBackColor = false;
            this.bnexit.Click += new System.EventHandler(this.bnexit_Click);
            // 
            // bnfinish
            // 
            this.bnfinish.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnfinish.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnfinish.Location = new System.Drawing.Point(6, 208);
            this.bnfinish.Name = "bnfinish";
            this.bnfinish.Size = new System.Drawing.Size(115, 51);
            this.bnfinish.TabIndex = 2;
            this.bnfinish.Text = "Finalize Order";
            this.bnfinish.UseVisualStyleBackColor = false;
            this.bnfinish.Click += new System.EventHandler(this.bnfinish_Click);
            // 
            // bninventory
            // 
            this.bninventory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bninventory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bninventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bninventory.Location = new System.Drawing.Point(6, 263);
            this.bninventory.Name = "bninventory";
            this.bninventory.Size = new System.Drawing.Size(115, 39);
            this.bninventory.TabIndex = 1;
            this.bninventory.Text = "Inventory";
            this.bninventory.UseVisualStyleBackColor = false;
            this.bninventory.Click += new System.EventHandler(this.bninventory_Click);
            // 
            // bnaccepetorder
            // 
            this.bnaccepetorder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnaccepetorder.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnaccepetorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnaccepetorder.Location = new System.Drawing.Point(6, 160);
            this.bnaccepetorder.Name = "bnaccepetorder";
            this.bnaccepetorder.Size = new System.Drawing.Size(115, 42);
            this.bnaccepetorder.TabIndex = 0;
            this.bnaccepetorder.Text = "Accept Order";
            this.bnaccepetorder.UseVisualStyleBackColor = false;
            this.bnaccepetorder.Click += new System.EventHandler(this.bnaccepetorder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Controls.Add(this.bnprofile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbname.Location = new System.Drawing.Point(908, 14);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(0, 18);
            this.lbname.TabIndex = 3;
            // 
            // bnprofile
            // 
            this.bnprofile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnprofile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnprofile.BackgroundImage")));
            this.bnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnprofile.FlatAppearance.BorderSize = 0;
            this.bnprofile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnprofile.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bnprofile.Location = new System.Drawing.Point(836, 12);
            this.bnprofile.Name = "bnprofile";
            this.bnprofile.Size = new System.Drawing.Size(44, 37);
            this.bnprofile.TabIndex = 2;
            this.bnprofile.UseVisualStyleBackColor = false;
            this.bnprofile.Click += new System.EventHandler(this.bnprofile_Click);
            // 
            // pninventory
            // 
            this.pninventory.BackColor = System.Drawing.Color.Azure;
            this.pninventory.Controls.Add(this.groupBox2);
            this.pninventory.Controls.Add(this.groupBox1);
            this.pninventory.Controls.Add(this.dgvinventory);
            this.pninventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pninventory.Location = new System.Drawing.Point(0, 0);
            this.pninventory.Name = "pninventory";
            this.pninventory.Size = new System.Drawing.Size(833, 390);
            this.pninventory.TabIndex = 1;
            this.pninventory.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.tbsearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Century", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(164, 32);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(136, 28);
            this.tbsearch.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingredient Name:";
            // 
            // bnsearch
            // 
            this.bnsearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnsearch.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnsearch.Location = new System.Drawing.Point(219, 81);
            this.bnsearch.Name = "bnsearch";
            this.bnsearch.Size = new System.Drawing.Size(81, 31);
            this.bnsearch.TabIndex = 8;
            this.bnsearch.Text = "Search";
            this.bnsearch.UseVisualStyleBackColor = false;
            this.bnsearch.Click += new System.EventHandler(this.bnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbcategory);
            this.groupBox1.Controls.Add(this.bndelete);
            this.groupBox1.Controls.Add(this.bnupdate);
            this.groupBox1.Controls.Add(this.bnenter);
            this.groupBox1.Controls.Add(this.tbquantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.lbfoodname);
            this.groupBox1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(318, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 335);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category:";
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Items.AddRange(new object[] {
            "Meat",
            "Vegetables",
            "Fruits",
            "Dairy",
            "Grains&Carbs",
            "Spices&Seasonings",
            "Sauces & Condiments",
            "Beverages & Additives",
            "Oils & Fats",
            "Sweeteners"});
            this.cbcategory.Location = new System.Drawing.Point(176, 122);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(143, 29);
            this.cbcategory.TabIndex = 8;
            // 
            // bndelete
            // 
            this.bndelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bndelete.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bndelete.Location = new System.Drawing.Point(375, 298);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(81, 31);
            this.bndelete.TabIndex = 7;
            this.bndelete.Text = "Delete";
            this.bndelete.UseVisualStyleBackColor = false;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // bnupdate
            // 
            this.bnupdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnupdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnupdate.Location = new System.Drawing.Point(288, 298);
            this.bnupdate.Name = "bnupdate";
            this.bnupdate.Size = new System.Drawing.Size(81, 31);
            this.bnupdate.TabIndex = 6;
            this.bnupdate.Text = "Update";
            this.bnupdate.UseVisualStyleBackColor = false;
            this.bnupdate.Click += new System.EventHandler(this.bnupdate_Click);
            // 
            // bnenter
            // 
            this.bnenter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnenter.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnenter.Location = new System.Drawing.Point(201, 298);
            this.bnenter.Name = "bnenter";
            this.bnenter.Size = new System.Drawing.Size(81, 31);
            this.bnenter.TabIndex = 5;
            this.bnenter.Text = "Enter";
            this.bnenter.UseVisualStyleBackColor = false;
            this.bnenter.Click += new System.EventHandler(this.bnenter_Click);
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(176, 81);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(239, 28);
            this.tbquantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(176, 28);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(239, 28);
            this.tbname.TabIndex = 2;
            // 
            // lbfoodname
            // 
            this.lbfoodname.AutoSize = true;
            this.lbfoodname.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfoodname.Location = new System.Drawing.Point(9, 35);
            this.lbfoodname.Name = "lbfoodname";
            this.lbfoodname.Size = new System.Drawing.Size(167, 21);
            this.lbfoodname.TabIndex = 1;
            this.lbfoodname.Text = "Ingredient Name:";
            // 
            // dgvinventory
            // 
            this.dgvinventory.AllowUserToAddRows = false;
            this.dgvinventory.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinventory.Location = new System.Drawing.Point(6, 156);
            this.dgvinventory.MultiSelect = false;
            this.dgvinventory.Name = "dgvinventory";
            this.dgvinventory.RowHeadersWidth = 51;
            this.dgvinventory.RowTemplate.Height = 24;
            this.dgvinventory.Size = new System.Drawing.Size(306, 211);
            this.dgvinventory.TabIndex = 0;
            // 
            // pnfinished
            // 
            this.pnfinished.BackColor = System.Drawing.Color.Azure;
            this.pnfinished.Controls.Add(this.dgvfinal);
            this.pnfinished.Controls.Add(this.cbselectid);
            this.pnfinished.Controls.Add(this.bnfinal);
            this.pnfinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnfinished.Location = new System.Drawing.Point(0, 0);
            this.pnfinished.Name = "pnfinished";
            this.pnfinished.Size = new System.Drawing.Size(833, 390);
            this.pnfinished.TabIndex = 0;
            this.pnfinished.Visible = false;
            this.pnfinished.Paint += new System.Windows.Forms.PaintEventHandler(this.pnfinished_Paint);
            // 
            // dgvfinal
            // 
            this.dgvfinal.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvfinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfinal.Location = new System.Drawing.Point(58, 42);
            this.dgvfinal.Name = "dgvfinal";
            this.dgvfinal.RowHeadersWidth = 51;
            this.dgvfinal.RowTemplate.Height = 24;
            this.dgvfinal.Size = new System.Drawing.Size(421, 262);
            this.dgvfinal.TabIndex = 3;
            // 
            // cbselectid
            // 
            this.cbselectid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbselectid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbselectid.FormattingEnabled = true;
            this.cbselectid.Location = new System.Drawing.Point(595, 238);
            this.cbselectid.Name = "cbselectid";
            this.cbselectid.Size = new System.Drawing.Size(179, 30);
            this.cbselectid.TabIndex = 5;
            // 
            // bnfinal
            // 
            this.bnfinal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnfinal.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnfinal.Location = new System.Drawing.Point(595, 282);
            this.bnfinal.Name = "bnfinal";
            this.bnfinal.Size = new System.Drawing.Size(179, 32);
            this.bnfinal.TabIndex = 4;
            this.bnfinal.Text = "Finalize  Order";
            this.bnfinal.UseVisualStyleBackColor = false;
            this.bnfinal.Click += new System.EventHandler(this.bnfinal_Click);
            // 
            // pnaccept
            // 
            this.pnaccept.BackColor = System.Drawing.Color.Azure;
            this.pnaccept.Controls.Add(this.lbOrder);
            this.pnaccept.Controls.Add(this.cbid);
            this.pnaccept.Controls.Add(this.bnaccept);
            this.pnaccept.Controls.Add(this.dgvpendingorder);
            this.pnaccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnaccept.Location = new System.Drawing.Point(0, 0);
            this.pnaccept.Name = "pnaccept";
            this.pnaccept.Size = new System.Drawing.Size(833, 390);
            this.pnaccept.TabIndex = 0;
            this.pnaccept.Visible = false;
            // 
            // cbid
            // 
            this.cbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(626, 256);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(179, 24);
            this.cbid.TabIndex = 2;
            this.cbid.SelectedIndexChanged += new System.EventHandler(this.cbid_SelectedIndexChanged);
            // 
            // bnaccept
            // 
            this.bnaccept.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnaccept.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnaccept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnaccept.Location = new System.Drawing.Point(626, 304);
            this.bnaccept.Name = "bnaccept";
            this.bnaccept.Size = new System.Drawing.Size(179, 32);
            this.bnaccept.TabIndex = 1;
            this.bnaccept.Text = "Accept Order";
            this.bnaccept.UseVisualStyleBackColor = false;
            this.bnaccept.Click += new System.EventHandler(this.bnaccept_Click);
            // 
            // dgvpendingorder
            // 
            this.dgvpendingorder.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvpendingorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpendingorder.Location = new System.Drawing.Point(36, 22);
            this.dgvpendingorder.Name = "dgvpendingorder";
            this.dgvpendingorder.RowHeadersWidth = 51;
            this.dgvpendingorder.RowTemplate.Height = 24;
            this.dgvpendingorder.Size = new System.Drawing.Size(519, 302);
            this.dgvpendingorder.TabIndex = 0;
            // 
            // pncontainer
            // 
            this.pncontainer.BackColor = System.Drawing.Color.LightCyan;
            this.pncontainer.Controls.Add(this.pninventory);
            this.pncontainer.Controls.Add(this.pnfinished);
            this.pncontainer.Controls.Add(this.pnaccept);
            this.pncontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncontainer.Location = new System.Drawing.Point(124, 57);
            this.pncontainer.Name = "pncontainer";
            this.pncontainer.Size = new System.Drawing.Size(833, 390);
            this.pncontainer.TabIndex = 2;
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 16;
            this.lbOrder.Location = new System.Drawing.Point(618, 94);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(187, 148);
            this.lbOrder.TabIndex = 3;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 447);
            this.Controls.Add(this.pncontainer);
            this.Controls.Add(this.pnselect);
            this.Controls.Add(this.panel1);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            this.pnselect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pninventory.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventory)).EndInit();
            this.pnfinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfinal)).EndInit();
            this.pnaccept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpendingorder)).EndInit();
            this.pncontainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnselect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button bnprofile;
        private System.Windows.Forms.Button bnfinish;
        private System.Windows.Forms.Button bninventory;
        private System.Windows.Forms.Button bnaccepetorder;
        private System.Windows.Forms.Panel pninventory;
        private System.Windows.Forms.Panel pnfinished;
        private System.Windows.Forms.Panel pnaccept;
        private System.Windows.Forms.Button bnaccept;
        private System.Windows.Forms.DataGridView dgvpendingorder;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.ComboBox cbselectid;
        private System.Windows.Forms.Button bnfinal;
        private System.Windows.Forms.DataGridView dgvfinal;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbfoodname;
        private System.Windows.Forms.DataGridView dgvinventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bndelete;
        private System.Windows.Forms.Button bnupdate;
        private System.Windows.Forms.Button bnenter;
        private System.Windows.Forms.Button bnsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Panel pncontainer;
        private System.Windows.Forms.Button bnlogout;
        private System.Windows.Forms.Button bnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbOrder;
    }
}