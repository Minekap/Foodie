namespace FoodiePointt
{
    partial class MainMenu
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
            this.bnlogin = new System.Windows.Forms.Button();
            this.pnframe = new System.Windows.Forms.Panel();
            this.bnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnaboutus = new System.Windows.Forms.Button();
            this.pnframe2 = new System.Windows.Forms.Panel();
            this.lbfoodiepoint = new System.Windows.Forms.Label();
            this.pncontainer = new System.Windows.Forms.Panel();
            this.pnimage = new System.Windows.Forms.Panel();
            this.pnaboutus = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbabout1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnframe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnframe2.SuspendLayout();
            this.pncontainer.SuspendLayout();
            this.pnaboutus.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnlogin
            // 
            this.bnlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnlogin.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnlogin.Location = new System.Drawing.Point(20, 174);
            this.bnlogin.Name = "bnlogin";
            this.bnlogin.Size = new System.Drawing.Size(122, 50);
            this.bnlogin.TabIndex = 5;
            this.bnlogin.Text = "login";
            this.bnlogin.UseVisualStyleBackColor = false;
            this.bnlogin.Click += new System.EventHandler(this.bnlogin_Click);
            // 
            // pnframe
            // 
            this.pnframe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnframe.Controls.Add(this.bnexit);
            this.pnframe.Controls.Add(this.button1);
            this.pnframe.Controls.Add(this.pictureBox1);
            this.pnframe.Controls.Add(this.bnaboutus);
            this.pnframe.Controls.Add(this.bnlogin);
            this.pnframe.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnframe.Location = new System.Drawing.Point(730, 65);
            this.pnframe.Name = "pnframe";
            this.pnframe.Size = new System.Drawing.Size(154, 404);
            this.pnframe.TabIndex = 6;
            // 
            // bnexit
            // 
            this.bnexit.BackgroundImage = global::FoodiePointt.Properties.Resources.logout;
            this.bnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnexit.Location = new System.Drawing.Point(62, 329);
            this.bnexit.Name = "bnexit";
            this.bnexit.Size = new System.Drawing.Size(67, 63);
            this.bnexit.TabIndex = 9;
            this.bnexit.UseVisualStyleBackColor = true;
            this.bnexit.Click += new System.EventHandler(this.bnexit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FoodiePointt.Properties.Resources.logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(560, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 63);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FoodiePointt.Properties.Resources.Foodiepoint;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FoodiePointt.Properties.Resources.Foodiepoint;
            this.pictureBox1.Location = new System.Drawing.Point(35, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bnaboutus
            // 
            this.bnaboutus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnaboutus.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnaboutus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnaboutus.Location = new System.Drawing.Point(20, 230);
            this.bnaboutus.Name = "bnaboutus";
            this.bnaboutus.Size = new System.Drawing.Size(122, 50);
            this.bnaboutus.TabIndex = 6;
            this.bnaboutus.Text = "About";
            this.bnaboutus.UseVisualStyleBackColor = false;
            this.bnaboutus.Click += new System.EventHandler(this.bnaboutus_Click);
            // 
            // pnframe2
            // 
            this.pnframe2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnframe2.Controls.Add(this.lbfoodiepoint);
            this.pnframe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnframe2.Location = new System.Drawing.Point(0, 0);
            this.pnframe2.Name = "pnframe2";
            this.pnframe2.Size = new System.Drawing.Size(884, 65);
            this.pnframe2.TabIndex = 7;
            // 
            // lbfoodiepoint
            // 
            this.lbfoodiepoint.AutoSize = true;
            this.lbfoodiepoint.Font = new System.Drawing.Font("Century", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfoodiepoint.Location = new System.Drawing.Point(3, 9);
            this.lbfoodiepoint.Name = "lbfoodiepoint";
            this.lbfoodiepoint.Size = new System.Drawing.Size(219, 39);
            this.lbfoodiepoint.TabIndex = 5;
            this.lbfoodiepoint.Text = "Foodiepoint ";
            // 
            // pncontainer
            // 
            this.pncontainer.Controls.Add(this.pnaboutus);
            this.pncontainer.Controls.Add(this.pnimage);
            this.pncontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncontainer.Location = new System.Drawing.Point(0, 65);
            this.pncontainer.Name = "pncontainer";
            this.pncontainer.Size = new System.Drawing.Size(730, 404);
            this.pncontainer.TabIndex = 8;
            // 
            // pnimage
            // 
            this.pnimage.BackgroundImage = global::FoodiePointt.Properties.Resources.Restaurant_for_group_reservation_Cafe_Savoy_1;
            this.pnimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnimage.Location = new System.Drawing.Point(0, 0);
            this.pnimage.Name = "pnimage";
            this.pnimage.Size = new System.Drawing.Size(730, 404);
            this.pnimage.TabIndex = 0;
            // 
            // pnaboutus
            // 
            this.pnaboutus.BackColor = System.Drawing.Color.Azure;
            this.pnaboutus.Controls.Add(this.label4);
            this.pnaboutus.Controls.Add(this.label3);
            this.pnaboutus.Controls.Add(this.label2);
            this.pnaboutus.Controls.Add(this.lbabout1);
            this.pnaboutus.Controls.Add(this.label1);
            this.pnaboutus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnaboutus.Location = new System.Drawing.Point(0, 0);
            this.pnaboutus.Name = "pnaboutus";
            this.pnaboutus.Size = new System.Drawing.Size(730, 404);
            this.pnaboutus.TabIndex = 1;
            this.pnaboutus.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "3. Foodiepoint provide  Hall for reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Served different type of cusine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.Foodiepoint served comfortable dining experience ";
            // 
            // lbabout1
            // 
            this.lbabout1.AutoSize = true;
            this.lbabout1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbabout1.Location = new System.Drawing.Point(82, 120);
            this.lbabout1.Name = "lbabout1";
            this.lbabout1.Size = new System.Drawing.Size(515, 23);
            this.lbabout1.TabIndex = 6;
            this.lbabout1.Text = "1.Foodiepoint is a restaurant located in Kuala Lumpur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Foodiepoint ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 469);
            this.Controls.Add(this.pncontainer);
            this.Controls.Add(this.pnframe);
            this.Controls.Add(this.pnframe2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Menu";
            this.pnframe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnframe2.ResumeLayout(false);
            this.pnframe2.PerformLayout();
            this.pncontainer.ResumeLayout(false);
            this.pnaboutus.ResumeLayout(false);
            this.pnaboutus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnlogin;
        private System.Windows.Forms.Panel pnframe;
        private System.Windows.Forms.Button bnaboutus;
        private System.Windows.Forms.Panel pnframe2;
        private System.Windows.Forms.Panel pncontainer;
        private System.Windows.Forms.Panel pnimage;
        private System.Windows.Forms.Panel pnaboutus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbfoodiepoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbabout1;
        private System.Windows.Forms.Label label1;
    }
}

