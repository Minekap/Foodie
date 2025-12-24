namespace FoodiePointt
{
    partial class Editprofile
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
            this.gbacc = new System.Windows.Forms.GroupBox();
            this.bnupdate = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.gbacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbacc
            // 
            this.gbacc.BackColor = System.Drawing.Color.Azure;
            this.gbacc.Controls.Add(this.bnupdate);
            this.gbacc.Controls.Add(this.tbpassword);
            this.gbacc.Controls.Add(this.label1);
            this.gbacc.Controls.Add(this.tbemail);
            this.gbacc.Controls.Add(this.lbemail);
            this.gbacc.Controls.Add(this.tbusername);
            this.gbacc.Controls.Add(this.lbname);
            this.gbacc.Location = new System.Drawing.Point(31, 105);
            this.gbacc.Name = "gbacc";
            this.gbacc.Size = new System.Drawing.Size(739, 240);
            this.gbacc.TabIndex = 10;
            this.gbacc.TabStop = false;
            // 
            // bnupdate
            // 
            this.bnupdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnupdate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnupdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnupdate.Location = new System.Drawing.Point(619, 189);
            this.bnupdate.Name = "bnupdate";
            this.bnupdate.Size = new System.Drawing.Size(101, 45);
            this.bnupdate.TabIndex = 8;
            this.bnupdate.Text = "Update";
            this.bnupdate.UseVisualStyleBackColor = false;
            this.bnupdate.Click += new System.EventHandler(this.bnupdate_Click);
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
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
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
            this.lbemail.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(41, 87);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(67, 21);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Email:";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(109, 41);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(439, 30);
            this.tbusername.TabIndex = 1;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(6, 49);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(106, 21);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Username:";
            // 
            // Editprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbacc);
            this.Name = "Editprofile";
            this.Text = "Editprofile";
            this.Load += new System.EventHandler(this.Editprofile_Load);
            this.gbacc.ResumeLayout(false);
            this.gbacc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbacc;
        private System.Windows.Forms.Button bnupdate;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label lbname;
    }
}