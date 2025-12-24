using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePointt
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
    
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            string stat;
            Login objl = new Login(tbemail.Text, tbpassword.Text);
            stat = objl.verify();
            


            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            else
          

            tbemail.Text = String.Empty;
            tbpassword.Text = String.Empty;
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateCustomer objl = new CreateCustomer();
            objl.Show();
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please visit the counter for assistance with resetting your password or email.");
        }
    }
}
