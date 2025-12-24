namespace FoodiePointt
{
    partial class CreateCustomer
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
            this.lbname = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.bnenter = new System.Windows.Forms.Button();
            this.gbacc = new System.Windows.Forms.GroupBox();
            this.gbacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(6, 49);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(97, 22);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Username:";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(109, 41);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(439, 30);
            this.tbusername.TabIndex = 1;
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(106, 82);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(439, 30);
            this.tbemail.TabIndex = 3;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(41, 87);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(59, 22);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Email:";
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(106, 128);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(439, 30);
            this.tbpassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(48, 169);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(52, 22);
            this.Role.TabIndex = 6;
            this.Role.Text = "Role:";
            // 
            // cbrole
            // 
            this.cbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "Customer"});
            this.cbrole.Location = new System.Drawing.Point(106, 169);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(100, 24);
            this.cbrole.TabIndex = 7;
            // 
            // bnenter
            // 
            this.bnenter.Location = new System.Drawing.Point(640, 178);
            this.bnenter.Name = "bnenter";
            this.bnenter.Size = new System.Drawing.Size(69, 45);
            this.bnenter.TabIndex = 8;
            this.bnenter.Text = "Enter";
            this.bnenter.UseVisualStyleBackColor = true;
            this.bnenter.Click += new System.EventHandler(this.bnenter_Click);
            // 
            // gbacc
            // 
            this.gbacc.BackColor = System.Drawing.Color.Azure;
            this.gbacc.Controls.Add(this.bnenter);
            this.gbacc.Controls.Add(this.cbrole);
            this.gbacc.Controls.Add(this.Role);
            this.gbacc.Controls.Add(this.tbpassword);
            this.gbacc.Controls.Add(this.label1);
            this.gbacc.Controls.Add(this.tbemail);
            this.gbacc.Controls.Add(this.lbemail);
            this.gbacc.Controls.Add(this.tbusername);
            this.gbacc.Controls.Add(this.lbname);
            this.gbacc.Location = new System.Drawing.Point(38, 121);
            this.gbacc.Name = "gbacc";
            this.gbacc.Size = new System.Drawing.Size(739, 240);
            this.gbacc.TabIndex = 9;
            this.gbacc.TabStop = false;
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbacc);
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            this.gbacc.ResumeLayout(false);
            this.gbacc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Button bnenter;
        private System.Windows.Forms.GroupBox gbacc;
    }
}