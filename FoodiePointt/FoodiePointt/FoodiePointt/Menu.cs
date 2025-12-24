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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

     

        private void bnlogin_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
            
        }

        private void bnaboutus_Click(object sender, EventArgs e)
        {
            pnaboutus.Visible = true;
            pnaboutus.BringToFront();
        }

        private void bnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
