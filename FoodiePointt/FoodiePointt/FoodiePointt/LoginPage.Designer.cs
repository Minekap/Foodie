namespace FoodiePointt
{
    partial class LoginPage
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
            this.lbemail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnforgot = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bncreatecustomer = new System.Windows.Forms.LinkLabel();
            this.bnenter = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(66, 75);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(66, 25);
            this.lbemail.TabIndex = 0;
            this.lbemail.Text = "Email:";
            this.lbemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.bnforgot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bncreatecustomer);
            this.groupBox1.Controls.Add(this.bnenter);
            this.groupBox1.Controls.Add(this.tbpassword);
            this.groupBox1.Controls.Add(this.lbemail);
            this.groupBox1.Controls.Add(this.tbemail);
            this.groupBox1.Controls.Add(this.lbpassword);
            this.groupBox1.Location = new System.Drawing.Point(51, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 345);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bnforgot
            // 
            this.bnforgot.AutoSize = true;
            this.bnforgot.Location = new System.Drawing.Point(301, 178);
            this.bnforgot.Name = "bnforgot";
            this.bnforgot.Size = new System.Drawing.Size(116, 16);
            this.bnforgot.TabIndex = 12;
            this.bnforgot.TabStop = true;
            this.bnforgot.Text = "Forgot Password?";
            this.bnforgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbforgot_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log out";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FoodiePointt.Properties.Resources.logout;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(669, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bncreatecustomer
            // 
            this.bncreatecustomer.AutoSize = true;
            this.bncreatecustomer.Location = new System.Drawing.Point(135, 178);
            this.bncreatecustomer.Name = "bncreatecustomer";
            this.bncreatecustomer.Size = new System.Drawing.Size(131, 16);
            this.bncreatecustomer.TabIndex = 5;
            this.bncreatecustomer.TabStop = true;
            this.bncreatecustomer.Text = "Create new account?";
            this.bncreatecustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bnenter
            // 
            this.bnenter.Location = new System.Drawing.Point(464, 205);
            this.bnenter.Name = "bnenter";
            this.bnenter.Size = new System.Drawing.Size(110, 50);
            this.bnenter.TabIndex = 4;
            this.bnenter.Text = "enter";
            this.bnenter.UseVisualStyleBackColor = true;
            this.bnenter.Click += new System.EventHandler(this.bnenter_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(138, 133);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(436, 30);
            this.tbpassword.TabIndex = 3;
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(138, 72);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(436, 30);
            this.tbemail.TabIndex = 2;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(28, 138);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(104, 25);
            this.lbpassword.TabIndex = 1;
            this.lbpassword.Text = "Password:";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Button bnenter;
        private System.Windows.Forms.LinkLabel bncreatecustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel bnforgot;
    }
}