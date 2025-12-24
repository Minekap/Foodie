using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace FoodiePointt
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }
       

        private void bnenter_Click(object sender, EventArgs e)
        {
            string stat;

            CreateAccount objl = new CreateAccount(tbusername.Text, tbemail.Text, tbpassword.Text, cbrole.Text);
            stat = objl.Addaccount();
            MessageBox.Show(stat);
        }

        private void bnupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
